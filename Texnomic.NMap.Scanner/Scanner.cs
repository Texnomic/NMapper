// This file is part of SaltwaterTaffy, an nmap wrapper library for .NET
// Copyright (C) 2013 Thom Dixon <thom@thomdixon.org>
// Released under the GNU GPLv2 or any later version

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using Texnomic.NMap.Schema;
using Texnomic.NMap.Schema.Models;

namespace Texnomic.NMap.Scanner
{
    /// <summary>
    ///     High-level scanner object for performing network reconnaissance using nmap
    /// </summary>
    public class Scanner
    {
        private readonly Dictionary<ScanType, NmapFlag> ScanTypeToNmapFlag = new Dictionary<ScanType, NmapFlag>
            {
                {ScanType.Null, NmapFlag.TcpNullScan},
                {ScanType.Fin, NmapFlag.FinScan},
                {ScanType.Xmas, NmapFlag.XmasScan},
                {ScanType.Syn, NmapFlag.TcpSynScan},
                {ScanType.Connect, NmapFlag.ConnectScan},
                {ScanType.Ack, NmapFlag.AckScan},
                {ScanType.Window, NmapFlag.WindowScan},
                {ScanType.Maimon, NmapFlag.MaimonScan},
                {ScanType.SctpInit, NmapFlag.SctpInitScan},
                {ScanType.SctpCookieEcho, NmapFlag.CookieEchoScan},
                {ScanType.Udp, NmapFlag.UdpScan}
            };

        /// <summary>
        ///     Create a new scanner with an intended target and Nmap process window style.
        ///     
        ///     Nmap ProcessWindowStyle is hidden if no argument is passed in.
        /// </summary>
        /// <param name="ExecutablePath"></param>
        /// <param name="Target">Intended target</param>
        public Scanner(string ExecutablePath, Target Target, ProcessWindowStyle NmapWindowStyle = ProcessWindowStyle.Hidden)
        {
            this.ExecutablePath = ExecutablePath;
            this.Target = Target;
            this.NmapWindowStyle = NmapWindowStyle;
        }

        public readonly string ExecutablePath;

        /// <summary>
        ///     Intended target.
        /// </summary>
        public Target Target { get; set; }

        /// <summary>
        ///     NmapOptions that should persist between runs (e.g., --exclude foobar)
        /// </summary>
        public NmapOptions Options { get; set; } = new NmapOptions();

        /// <summary>
        ///     Set the Nmap process window style. Default is Hidden.
        /// </summary>
        public ProcessWindowStyle NmapWindowStyle { get; set; }

        /// <summary>
        ///     Create a new NmapContext with the intended target and our persistent options
        /// </summary>
        /// <returns>NmapContext with the intended target and our persistent options</returns>
        private NmapContext GetContext()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                throw new ApplicationException("No network reachable");
            }

            var NmapContext = new NmapContext(ExecutablePath)
            {
                Target = Target.ToString(),
                WindowStyle = NmapWindowStyle
            };

            if (Options != null)
            {
                NmapContext.Options.AddAll(Options);
            }

            return NmapContext;
        }

        /// <summary>
        ///     Perform host discovery and OS detection on the intended target (preferably a subnet or IP range)
        /// </summary>
        /// <returns>A collection of Hosts detailing the results of the discovery</returns>
        public IEnumerable<Host> HostDiscovery()
        {
            var Ctx = GetContext();
            Ctx.Options.AddAll(new[]
                {
                    NmapFlag.TcpSynScan,
                    NmapFlag.OsDetection
                });

            return Ctx.Run().Hosts;
        }

        /// <summary>
        ///     Build an nmap context with the specified options
        /// </summary>
        /// <param name="ScanType">The desired type of scan to perform</param>
        /// <param name="Ports">The ports to scan (null of empty for default ports)</param>
        /// <returns>An nmap context for performing the desired scan</returns>
        private NmapContext _portScanCommon(ScanType ScanType, string Ports)
        {
            var NmapContext = GetContext();

            // We always try to detect the OS and the service versions
            NmapContext.Options.AddAll(new[]
                {
                    NmapFlag.ServiceVersion,
                    NmapFlag.OsDetection
                });

            // Add the appropriate flag if we're not performing a default scan
            if (ScanType != ScanType.Default)
            {
                NmapContext.Options.Add(ScanTypeToNmapFlag[ScanType]);
            }

            // Unless we specify UDP only, then perform a UDP scan in the same run
            if (ScanType != ScanType.Default && ScanType != ScanType.Udp)
            {
                NmapContext.Options.Add(NmapFlag.UdpScan);
            }

            // If we have a port specification, then use it
            if (!string.IsNullOrEmpty(Ports))
            {
                NmapContext.Options.Add(NmapFlag.PortSpecification, Ports);
            }

            return NmapContext;
        }

        /// <summary>
        ///     Perform a TCP port scan with service detection and OS detection.
        /// </summary>
        /// <returns>A NMapRun object detailing the results of the port scan</returns>
        public NMapResult PortScan()
        {
            var NmapContext = _portScanCommon(ScanType.Default, null);
            return NmapContext.Run();
        }

        /// <summary>
        ///     Perform the desired scan with service detection and OS detection.
        /// </summary>
        /// <returns>A NMapRun object detailing the results of the port scan</returns>
        public NMapResult PortScan(ScanType ScanType)
        {
            var NmapContext = _portScanCommon(ScanType, null);
            return NmapContext.Run();
        }

        /// <summary>
        ///     Perform a TCP port scan on the specified ports with service detection and OS detection.
        /// </summary>
        /// <param name="ScanType">The type of scan to perform</param>
        /// <param name="Ports">A list of ports to scan</param>
        /// <returns>A NMapRun object detailing the results of the port scan</returns>
        public NMapResult PortScan(ScanType ScanType, IEnumerable<int> Ports)
        {
            var NmapContext = _portScanCommon(ScanType,
                                              string.Join(",",
                                                          Ports.Select(X => X.ToString(CultureInfo.InvariantCulture))));
            return NmapContext.Run();
        }

        /// <summary>
        ///     Perform a TCP port scan on the specified ports with service detection and OS detection.
        /// </summary>
        /// <param name="ScanType">The type of scan to perform</param>
        /// <param name="Ports">A string detailing which ports to scan (e.g., "10-20,33")</param>
        /// <returns>A NMapRun object detailing the results of the port scan</returns>
        public NMapResult PortScan(ScanType ScanType, string Ports)
        {
            var NmapContext = _portScanCommon(ScanType, Ports);
            return NmapContext.Run();
        }

        /// <summary>
        ///     Yield a list of our own network interfaces (first half of nmap --iflist)
        /// </summary>
        /// <returns>A list of our network interfaces</returns>
        public NetworkInterface[] GetAllHostNetworkInterfaces()
        {
            return NetworkInterface.GetAllNetworkInterfaces();
        }
    }
}
