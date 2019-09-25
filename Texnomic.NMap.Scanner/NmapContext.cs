using System;
using System.Diagnostics;
using System.IO;
using Texnomic.NMap.Scanner.Extensions;
using Texnomic.NMap.Schema;

namespace Texnomic.NMap.Scanner
{
    /// <summary>
    ///     A class that represents an nmap run
    /// </summary>
    public class NmapContext
    {
        /// <summary>
        ///     By default we try to find the path to the nmap executable by searching the path, the output XML file is a temporary file, and the nmap options are empty.
        ///     
        ///     Nmap ProcessWindowStyle is Hidden by default.
        /// </summary>
        public NmapContext(string ExecutablePath, ProcessWindowStyle WindowStyle = ProcessWindowStyle.Hidden)
        {
            Path = ExecutablePath;
            OutputPath = System.IO.Path.GetTempFileName();
            Options = new NmapOptions();
            this.WindowStyle = WindowStyle;
        }

        /// <summary>
        ///     The path to the nmap executable
        /// </summary>
        public readonly string Path;

        /// <summary>
        ///     The output path for the nmap XML file
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        ///     The specified nmap options
        /// </summary>
        public NmapOptions Options { get; set; }

        /// <summary>
        ///     The intended target
        /// </summary>
        public string Target { get; set; }

        public ProcessWindowStyle WindowStyle { get; set; }


        /// <summary>
        ///     Execute an nmap run with the specified options on the intended target, writing the resultant XML to the specified file
        /// </summary>
        /// <returns>An nmaprun object representing the result of an nmap run</returns>
        public virtual NMapResult Run()
        {
            if (string.IsNullOrEmpty(OutputPath))
            {
                throw new ApplicationException("Nmap output file path is null or empty");
            }

            if (string.IsNullOrEmpty(Path) || !File.Exists(Path))
            {
                throw new ApplicationException("Path to Nmap is invalid");
            }

            if (string.IsNullOrEmpty(Target))
            {
                throw new ApplicationException("Attempted run on empty target");
            }

            if (Options == null)
            {
                throw new ApplicationException("Nmap options null");
            }

            Options[NmapFlag.XmlOutput] = OutputPath;

            using (var Process = new Process())
            {
                Process.StartInfo.FileName = Path;
                Process.StartInfo.Arguments = $"{Options} {Target}";
                Process.StartInfo.WindowStyle = WindowStyle;
                Process.Start();
                Process.WaitForExit();

                if (!File.Exists(OutputPath))
                {
                    throw new NmapException(Process.StartInfo.Arguments);
                }
            }

            return Serialization.DeserializeFromFile<NMapResult>(OutputPath);
        }
    }
}