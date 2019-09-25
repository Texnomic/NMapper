// This file is part of SaltwaterTaffy, an nmap wrapper library for .NET
// Copyright (C) 2013 Thom Dixon <thom@thomdixon.org>
// Released under the GNU GPLv2 or any later version

namespace Texnomic.NMap.Scanner
{
    /// <summary>
    ///     Struct representing a service (e.g., ssh, httpd) running on a host
    /// </summary>
    public struct Service
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public string Os { get; set; }
        public string Version { get; set; }
    }
}