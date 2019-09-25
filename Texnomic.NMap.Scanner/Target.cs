using System.Collections.Generic;
using System.Net;

namespace Texnomic.NMap.Scanner
{
    /// <summary>
    ///     Object representing the target(s) of an nmap scan
    /// </summary>
    public struct Target
    {
        private readonly string _target;

        public Target(string Target)
        {
            _target = Target;
        }

        public Target(IPAddress Target)
        {
            _target = Target.ToString();
        }

        public Target(IEnumerable<IPAddress> Target)
        {
            _target = string.Join(" ", Target);
        }

        public Target(IEnumerable<string> Targets)
        {
            _target = string.Join(" ", Targets);
        }

        public override string ToString()
        {
            return _target;
        }
    }
}