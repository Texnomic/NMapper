// This file is part of SaltwaterTaffy, an nmap wrapper library for .NET
// Copyright (C) 2013 Thom Dixon <thom@thomdixon.org>
// Released under the GNU GPLv2 or any later version
namespace Texnomic.NMap.Scanner
{
    public static class StringExtensions
    {
        public static string Capitalize(this string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return string.Empty;
            }

            var A = S.ToCharArray();
            A[0] = char.ToUpper(A[0]);

            return new string(A);
        }
    }
}