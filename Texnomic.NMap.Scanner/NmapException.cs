using System;

namespace Texnomic.NMap.Scanner
{
    public class NmapException : ApplicationException
    {
        public NmapException(string Ex) : base(Ex)
        {
        }
    }
}