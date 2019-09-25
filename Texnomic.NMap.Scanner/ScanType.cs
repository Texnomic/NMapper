namespace Texnomic.NMap.Scanner
{
    /// <summary>
    ///     Enumeration of potential scan types, including TCP, UDP, and SCTP scans
    /// </summary>
    public enum ScanType
    {
        // Perform a scan of our choice
        Default,

        // TCP scans
        Null,
        Fin,
        Xmas,
        Syn,
        Connect,
        Ack,
        Window,
        Maimon,

        // SCTP scans
        SctpInit,
        SctpCookieEcho,

        // UDP-only scan
        Udp
    }
}