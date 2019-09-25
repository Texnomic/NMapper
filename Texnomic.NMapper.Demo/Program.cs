using System;
using Texnomic.NMap.Scanner;

namespace Texnomic.NMapper.Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Target = new Target("10.0.0.254");

            var Scanner = new Scanner(@"C:\Users\Texnomic\Downloads\Compressed\nmap-7.80\nmap.exe", Target)
            {
                Options = new NmapOptions() { NmapFlag.TreatHostsAsOnline, { NmapFlag.TopPorts, "5" }, NmapFlag.Reason }
            };


            var Result = Scanner.PortScan(ScanType.Syn);

        }
    }
}
