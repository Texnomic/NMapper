namespace Texnomic.NMap.Scanner
{
    /// <summary>
    ///     Struct which represents the "extraports" information produced by nmap
    /// </summary>
    public struct ExtraPorts
    {
        public int Count { get; set; }
        public string State { get; set; }
    }
}