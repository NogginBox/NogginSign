namespace NogginSign.net.Constants
{
    /// <summary>
    /// Constants used in transmission packets
    /// </summary>
    public static class PacketConstants
    {
        public const string NUL     = "\x00";  // NULL
        public const string SOH     = "\x01";  // Start of Header
        public const string STX     = "\x02";  // Start of TeXt (precedes a command code)
        public const string ETX     = "\x03";  // End of TeXt
        public const string EOT     = "\x04";  // End Of Transmission
        //public const string #ENQ    = "\x05"  # Enquiry
        //public const string #ACK    = "\x06"  # Acknowledge
        public const string BEL     = "\x07";  // Bell
        public const string BS      = "\x08";  // Backspace
        public const string HT      = "\x09";  // Horizontal tab
        public const string LF      = "\x0A";  // Line Feed
        public const string NL      = "\x0A";  // New Line
        public const string VT      = "\x0B";  // Vertical Tab
        //public const string #FF     = "\x0C"  # Form Feed
        public const string NP      = "\x0C";  // New Page
        public const string CR      = "\x0D";  // Carriage Return
        public const string CAN     = "\x18";  // Cancel
        public const string SUB     = "\x1A";  // Substitute (select charset)
        public const string ESC     = "\x1B";  // Escape character

        public const string NEWLINE = NL;
        public const string NEWPAGE = NP;
    }

}
