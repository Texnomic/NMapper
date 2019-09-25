// This file is part of SaltwaterTaffy, an nmap wrapper library for .NET
// Copyright (C) 2013 Thom Dixon <thom@thomdixon.org>
// Released under the GNU GPLv2 or any later version

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texnomic.NMap.Scanner
{
    /// <summary>
    ///     Class which represents command-line options for nmap
    /// </summary>
    public class NmapOptions : IDictionary<NmapFlag, string>
    {
        #region NmapFlagToOption

        private readonly Dictionary<NmapFlag, string> _nmapFlagToOption = new Dictionary<NmapFlag, string>
            {
                {NmapFlag.InputFilename, "-iL"},
                {NmapFlag.RandomTargets, "-iR"},
                {NmapFlag.ExcludeHosts, "--exclude"},
                {NmapFlag.ExcludeFile, "--excludefile"},
                {NmapFlag.ListScan, "-sL"},
                {NmapFlag.PingScan, "-sP"},
                {NmapFlag.TreatHostsAsOnline, "-PN"},
                {NmapFlag.TcpSynDiscovery, "-PS"},
                {NmapFlag.AckDiscovery, "-PA"},
                {NmapFlag.UdpDiscovery, "-PU"},
                {NmapFlag.SctpDiscovery, "-PY"},
                {NmapFlag.IcmpEchoDiscovery, "-PE"},
                {NmapFlag.IcmpTimestampDiscovery, "-PP"},
                {NmapFlag.IcmpNetmaskDiscovery, "-PM"},
                {NmapFlag.ProtocolPing, "-PO"},
                {NmapFlag.NeverDnsResolve, "-n"},
                {NmapFlag.DnsServers, "--dns-servers"},
                {NmapFlag.SystemDns, "--system-dns"},
                {NmapFlag.Traceroute, "--traceroute"},
                {NmapFlag.Hostscan, "-sn"},
                {NmapFlag.TcpSynScan, "-sS"},
                {NmapFlag.ConnectScan, "-sT"},
                {NmapFlag.AckScan, "-sA"},
                {NmapFlag.WindowScan, "-sW"},
                {NmapFlag.MaimonScan, "-sM"},
                {NmapFlag.UdpScan, "-sU"},
                {NmapFlag.TcpNullScan, "-sN"},
                {NmapFlag.FinScan, "-sF"},
                {NmapFlag.XmasScan, "-sX"},
                {NmapFlag.ScanFlags, "--scanflags"},
                {NmapFlag.IdleScan, "-sI"},
                {NmapFlag.SctpInitScan, "-sY"},
                {NmapFlag.CookieEchoScan, "-sZ"},
                {NmapFlag.IpProtocolScan, "-sO"},
                {NmapFlag.FtpBounceScan, "-b"},
                {NmapFlag.PortSpecification, "-p"},
                {NmapFlag.FastScanMode, "-F"},
                {NmapFlag.ScanPortsConsecutively, "-r"},
                {NmapFlag.TopPorts, "--top-ports"},
                {NmapFlag.PortRatio, "--port-ratio"},
                {NmapFlag.ServiceVersion, "-sV"},
                {NmapFlag.VersionIntensity, "--version-intensity"},
                {NmapFlag.VersionLight, "--version-light"},
                {NmapFlag.VersionAll, "--version-all"},
                {NmapFlag.VersionTrace, "--version-trace"},
                {NmapFlag.DefaultScriptScan, "-sC"},
                {NmapFlag.Script, "--script"},
                {NmapFlag.ScriptArgs, "--script-args"},
                {NmapFlag.ScriptTrace, "--script-trace"},
                {NmapFlag.ScriptUpdateDb, "--script-updatedb"},
                {NmapFlag.OsDetection, "-O"},
                {NmapFlag.OsScanLimit, "--osscan-limit"},
                {NmapFlag.OsScanGuess, "--osscan-guess"},
                {NmapFlag.ParanoidTiming, "-T0"},
                {NmapFlag.SneakyTiming, "-T1"},
                {NmapFlag.PoliteTiming, "-T2"},
                {NmapFlag.NormalTiming, "-T3"},
                {NmapFlag.AggressiveTiming, "-T4"},
                {NmapFlag.InsaneTiming, "-T5"},
                {NmapFlag.ParallelMinHostGroupSize, "--min-hostgroup"},
                {NmapFlag.ParallelMaxHostGroupSize, "--max-hostgroup"},
                {NmapFlag.MinProbeParallelization, "--min-parallelism"},
                {NmapFlag.MaxProbeParallelization, "--max-parallelism"},
                {NmapFlag.MinRttTimeout, "--min-rtt-timeout"},
                {NmapFlag.MaxRttTimeout, "--max-rtt-timeout"},
                {NmapFlag.InitialRttTimeout, "--initial-rtt-timeout"},
                {NmapFlag.MaxRetries, "--max-retries"},
                {NmapFlag.HostTimeout, "--host-timeout"},
                {NmapFlag.ScanDelay, "--scan-delay"},
                {NmapFlag.MaxScanDelay, "--max-scan-delay"},
                {NmapFlag.MinRate, "--min-rate"},
                {NmapFlag.MaxRate, "--max-rate"},
                {NmapFlag.FragmentPackets, "-f"},
                {NmapFlag.Mtu, "--mtu"},
                {NmapFlag.Decoy, "-D"},
                {NmapFlag.SpoofSourceAddress, "-S"},
                {NmapFlag.Interface, "-e"},
                {NmapFlag.SourcePortG, "-g"},
                {NmapFlag.SourcePort, "--source-port"},
                {NmapFlag.DataLength, "--data-length"},
                {NmapFlag.IpOptions, "--ip-options"},
                {NmapFlag.TimeToLive, "--ttl"},
                {NmapFlag.SpoofMacAddress, "--spoof-mac"},
                {NmapFlag.BadSum, "--badsum"},
                {NmapFlag.Adler32, "--adler32"},
                {NmapFlag.NormalOutput, "-oN"},
                {NmapFlag.XmlOutput, "-oX"},
                {NmapFlag.ScriptKiddieOutput, "-oS"},
                {NmapFlag.GreppableOutput, "-oG"},
                {NmapFlag.AllThreeOutput, "-oA"},
                {NmapFlag.Verbose, "-v"},
                {NmapFlag.DebugLevel, "-d"},
                {NmapFlag.Reason, "--reason"},
                {NmapFlag.Open, "--open"},
                {NmapFlag.PacketTrace, "--packet-trace"},
                {NmapFlag.PrintHostInterfaceList, "--iflist"},
                {NmapFlag.LogErrors, "--log-errors"},
                {NmapFlag.AppendOutput, "--append-output"},
                {NmapFlag.Resume, "--resume"},
                {NmapFlag.Stylesheet, "--stylesheet"},
                {NmapFlag.WebXml, "--webxml"},
                {NmapFlag.NoStylesheet, "--no-stylesheet"},
                {NmapFlag.Ipv6, "-6"},
                {NmapFlag.A, "-A"},
                {NmapFlag.DataDir, "--datadir"},
                {NmapFlag.SendEth, "--send-eth"},
                {NmapFlag.SendIp, "--send-ip"},
                {NmapFlag.Privileged, "--privileged"},
                {NmapFlag.Unprivileged, "--unprivileged"},
                {NmapFlag.Version, "-V"},
                {NmapFlag.Help, "-h"}
            };

        #endregion

        #region NmapOptionToFlag

        private readonly Dictionary<string, NmapFlag> _nmapOptionToFlag = new Dictionary<string, NmapFlag>
            {
                {"-iL", NmapFlag.InputFilename},
                {"-iR", NmapFlag.RandomTargets},
                {"--exclude", NmapFlag.ExcludeHosts},
                {"--excludefile", NmapFlag.ExcludeFile},
                {"-sL", NmapFlag.ListScan},
                {"-sP", NmapFlag.PingScan},
                {"-PN", NmapFlag.TreatHostsAsOnline},
                {"-PS", NmapFlag.TcpSynDiscovery},
                {"-PA", NmapFlag.AckDiscovery},
                {"-PU", NmapFlag.UdpDiscovery},
                {"-PY", NmapFlag.SctpDiscovery},
                {"-PE", NmapFlag.IcmpEchoDiscovery},
                {"-PP", NmapFlag.IcmpTimestampDiscovery},
                {"-PM", NmapFlag.IcmpNetmaskDiscovery},
                {"-PO", NmapFlag.ProtocolPing},
                {"-n", NmapFlag.NeverDnsResolve},
                {"--dns-servers", NmapFlag.DnsServers},
                {"--system-dns", NmapFlag.SystemDns},
                {"--traceroute", NmapFlag.Traceroute},
                {"-sn", NmapFlag.Hostscan},
                {"-sS", NmapFlag.TcpSynScan},
                {"-sT", NmapFlag.ConnectScan},
                {"-sA", NmapFlag.AckScan},
                {"-sW", NmapFlag.WindowScan},
                {"-sM", NmapFlag.MaimonScan},
                {"-sU", NmapFlag.UdpScan},
                {"-sN", NmapFlag.TcpNullScan},
                {"-sF", NmapFlag.FinScan},
                {"-sX", NmapFlag.XmasScan},
                {"--scanflags", NmapFlag.ScanFlags},
                {"-sI", NmapFlag.IdleScan},
                {"-sY", NmapFlag.SctpInitScan},
                {"-sZ", NmapFlag.CookieEchoScan},
                {"-sO", NmapFlag.IpProtocolScan},
                {"-b", NmapFlag.FtpBounceScan},
                {"-p", NmapFlag.PortSpecification},
                {"-F", NmapFlag.FastScanMode},
                {"-r", NmapFlag.ScanPortsConsecutively},
                {"--top-ports", NmapFlag.TopPorts},
                {"--port-ratio", NmapFlag.PortRatio},
                {"-sV", NmapFlag.ServiceVersion},
                {"--version-intensity", NmapFlag.VersionIntensity},
                {"--version-light", NmapFlag.VersionLight},
                {"--version-all", NmapFlag.VersionAll},
                {"--version-trace", NmapFlag.VersionTrace},
                {"-sC", NmapFlag.DefaultScriptScan},
                {"--script", NmapFlag.Script},
                {"--script-args", NmapFlag.ScriptArgs},
                {"--script-trace", NmapFlag.ScriptTrace},
                {"--script-updatedb", NmapFlag.ScriptUpdateDb},
                {"-O", NmapFlag.OsDetection},
                {"--osscan-limit", NmapFlag.OsScanLimit},
                {"--osscan-guess", NmapFlag.OsScanGuess},
                {"-T0", NmapFlag.ParanoidTiming},
                {"-T1", NmapFlag.SneakyTiming},
                {"-T2", NmapFlag.PoliteTiming},
                {"-T3", NmapFlag.NormalTiming},
                {"-T4", NmapFlag.AggressiveTiming},
                {"-T5", NmapFlag.InsaneTiming},
                {"--min-hostgroup", NmapFlag.ParallelMinHostGroupSize},
                {"--max-hostgroup", NmapFlag.ParallelMaxHostGroupSize},
                {"--min-parallelism", NmapFlag.MinProbeParallelization},
                {"--max-parallelism", NmapFlag.MaxProbeParallelization},
                {"--min-rtt-timeout", NmapFlag.MinRttTimeout},
                {"--max-rtt-timeout", NmapFlag.MaxRttTimeout},
                {"--initial-rtt-timeout", NmapFlag.InitialRttTimeout},
                {"--max-retries", NmapFlag.MaxRetries},
                {"--host-timeout", NmapFlag.HostTimeout},
                {"--scan-delay", NmapFlag.ScanDelay},
                {"--max-scan-delay", NmapFlag.MaxScanDelay},
                {"--min-rate", NmapFlag.MinRate},
                {"--max-rate", NmapFlag.MaxRate},
                {"-f", NmapFlag.FragmentPackets},
                {"--mtu", NmapFlag.Mtu},
                {"-D", NmapFlag.Decoy},
                {"-S", NmapFlag.SpoofSourceAddress},
                {"-e", NmapFlag.Interface},
                {"-g", NmapFlag.SourcePortG},
                {"--source-port", NmapFlag.SourcePort},
                {"--data-length", NmapFlag.DataLength},
                {"--ip-options", NmapFlag.IpOptions},
                {"--ttl", NmapFlag.TimeToLive},
                {"--spoof-mac", NmapFlag.SpoofMacAddress},
                {"--badsum", NmapFlag.BadSum},
                {"--adler32", NmapFlag.Adler32},
                {"-oN", NmapFlag.NormalOutput},
                {"-oX", NmapFlag.XmlOutput},
                {"-oS", NmapFlag.ScriptKiddieOutput},
                {"-oG", NmapFlag.GreppableOutput},
                {"-oA", NmapFlag.AllThreeOutput},
                {"-v", NmapFlag.Verbose},
                {"-d", NmapFlag.DebugLevel},
                {"--reason", NmapFlag.Reason},
                {"--open", NmapFlag.Open},
                {"--packet-trace", NmapFlag.PacketTrace},
                {"--iflist", NmapFlag.PrintHostInterfaceList},
                {"--log-errors", NmapFlag.LogErrors},
                {"--append-output", NmapFlag.AppendOutput},
                {"--resume", NmapFlag.Resume},
                {"--stylesheet", NmapFlag.Stylesheet},
                {"--webxml", NmapFlag.WebXml},
                {"--no-stylesheet", NmapFlag.NoStylesheet},
                {"-6", NmapFlag.Ipv6},
                {"-A", NmapFlag.A},
                {"--datadir", NmapFlag.DataDir},
                {"--send-eth", NmapFlag.SendEth},
                {"--send-ip", NmapFlag.SendIp},
                {"--privileged", NmapFlag.Privileged},
                {"--unprivileged", NmapFlag.Unprivileged},
                {"-V", NmapFlag.Version},
                {"-h", NmapFlag.Help}
            };

        #endregion

        private readonly Dictionary<string, string> _nmapOptions;

        public NmapOptions()
        {
            _nmapOptions = new Dictionary<string, string>();
        }

        public void Add(KeyValuePair<NmapFlag, string> Kvp)
        {
            Add(Kvp.Key, Kvp.Value);
        }

        public void Clear()
        {
            _nmapOptions.Clear();
        }

        public bool Contains(KeyValuePair<NmapFlag, string> Item)
        {
            return _nmapOptions.Contains(new KeyValuePair<string, string>(_nmapFlagToOption[Item.Key], Item.Value));
        }

        public void CopyTo(KeyValuePair<NmapFlag, string>[] Array, int ArrayIndex)
        {
            _nmapOptions.Select(X => new KeyValuePair<NmapFlag, string>(_nmapOptionToFlag[X.Key], X.Value))
                        .ToArray()
                        .CopyTo(Array, ArrayIndex);
        }

        public bool Remove(KeyValuePair<NmapFlag, string> Item)
        {
            return _nmapOptions.Remove(_nmapFlagToOption[Item.Key]);
        }

        public int Count => _nmapOptions.Count;

        public bool IsReadOnly => false;

        public bool ContainsKey(NmapFlag Key)
        {
            return _nmapOptions.ContainsKey(_nmapFlagToOption[Key]);
        }

        public void Add(NmapFlag Flag, string Argument)
        {
            var Option = _nmapFlagToOption[Flag];

            if (_nmapOptions.ContainsKey(Option))
            {
                _nmapOptions[Option] = $"{_nmapOptions[Option]},{Argument}";
            }
            else
            {
                _nmapOptions.Add(Option, Argument);
            }
        }

        public bool Remove(NmapFlag Key)
        {
            return _nmapOptions.Remove(_nmapFlagToOption[Key]);
        }

        public bool TryGetValue(NmapFlag Key, out string Value)
        {
            return _nmapOptions.TryGetValue(_nmapFlagToOption[Key], out Value);
        }

        public string this[NmapFlag Key]
        {
            get => _nmapOptions[_nmapFlagToOption[Key]];
            set => _nmapOptions[_nmapFlagToOption[Key]] = value;
        }

        public ICollection<NmapFlag> Keys
        {
            get { return _nmapOptions.Select(X => _nmapOptionToFlag[X.Key]).ToArray(); }
        }

        public ICollection<string> Values => _nmapOptions.Values;


        public IEnumerator<KeyValuePair<NmapFlag, string>> GetEnumerator()
        {
            return
                _nmapOptions.Select(X => new KeyValuePair<NmapFlag, string>(_nmapOptionToFlag[X.Key], X.Value))
                            .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(NmapFlag Flag)
        {
            Add(Flag, string.Empty);
        }

        public void AddAll(IEnumerable<NmapFlag> Flags)
        {
            foreach (var Flag in Flags)
            {
                Add(Flag);
            }
        }

        public void AddAll(IEnumerable<KeyValuePair<NmapFlag, string>> Kvps)
        {
            foreach (var Kvp in Kvps)
            {
                Add(Kvp.Key, Kvp.Value);
            }
        }

        public override string ToString()
        {
            return
                _nmapOptions.Aggregate(new StringBuilder(), (Sb, Kvp) => Sb.AppendFormat("{0} {1} ", Kvp.Key, Kvp.Value),
                                       Sb => Sb.ToString()).Trim();
        }
    }
}