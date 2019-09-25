using System;
using System.Diagnostics;
using System.IO;

namespace Texnomic.NMap.Scanner
{
    public class NdiffContext
    {
        /// <summary>
        ///     By default we try to find the path to the ndiff executable by searching the path and the ndiff options are empty.
        /// </summary>
        public NdiffContext(string ExecutablePath)
        {
            //using NmapContext to get the path so as to not duplicate code for finding the executable in the PATH
            Path = ExecutablePath;
            Options = new NdiffOptions();
        }

        /// <summary>
        ///     The path to the ndiff executable
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///     The specified ndiff options
        /// </summary>
        public NdiffOptions Options { get; set; }

        /// <summary>
        ///     Original file to compare. FILE1 as per ndiff -h
        /// </summary>
        public string File1 { get; set; }

        /// <summary>
        ///     Original file to compare. FILE2 as per ndiff -h
        /// </summary>
        public string File2 { get; set; }

        /// <summary>
        ///     Run the Ndiff tool to compare output files from Nmap.
        /// </summary>
        /// <returns>The Ndiff comparison output.</returns>
        public string Run()
        {
            if (string.IsNullOrEmpty(Path) || !File.Exists(Path))
            {
                throw new ApplicationException("Path to ndiff is invalid");
            }

            if (string.IsNullOrEmpty(File1))
            {
                throw new ApplicationException("Attempted run on missing comparison File1.");
            }

            if (string.IsNullOrEmpty(File2))
            {
                throw new ApplicationException("Attempted run on missing comparison File2.");
            }

            if (Options == null)
            {
                throw new ApplicationException("Ndiff options null");
            }

            string Output, Error;

            using (var Process = new Process())
            {
                Process.StartInfo.FileName = Path;
                Process.StartInfo.Arguments = $"{Options} {File1} {File2}";
                Process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process.StartInfo.UseShellExecute = false;
                Process.StartInfo.RedirectStandardOutput = true;
                Process.StartInfo.RedirectStandardError = true;
                Process.Start();
                Process.WaitForExit();

                Output = Process.StandardOutput.ReadToEnd();
                Error = Process.StandardError.ReadToEnd();
            }
            

            return string.IsNullOrEmpty(Error) ? Output : Error;
        }
    }
}