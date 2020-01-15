namespace NogginSign.Constants
{
    public static class CommandCodes
    {
        public const string WRITE_TEXT          = "A";  // Write TEXT file (p18)
        public const string READ_TEXT           = "B";  // Read TEXT file (p19)
        public const string WRITE_SPECIAL       = "E";  // Write SPECIAL FUNCTION commands (p21)
        public const string READ_SPECIAL        = "F";  // Read SPECIAL FUNCTION commands (p29)
        public const string WRITE_STRING        = "G";  // Write STRING (p37)
        public const string READ_STRING         = "H";  // Read STRING (p38)
        public const string WRITE_SMALL_DOTS    = "I";  // Write SMALL DOTS PICTURE file (p39)
        public const string READ_SMALL_DOTS     = "J";  // Read SMALL DOTS PICTURE file (p41)
        public const string WRITE_RGB_DOTS      = "K";  // Write RGB DOTS PICTURE file (p44)
        public const string READ_RGB_DOTS       = "L";  // Read RGB DOTS PICTURE file (p46)
        public const string WRITE_LARGE_DOTS    = "M";  // Write LARGE DOTS PICTURE file (p42)
        public const string READ_LARGE_DOTS     = "N";  // Read LARGE DOTS PICTURE file (p43)
        public const string WRITE_ALPHAVISION   = "O";  // Write ALPHAVISION BULLETIN (p48)
        public const string SET_TIMEOUT         = "T";  // Set Timeout Message (p118) (Alpha 2.0/3.0)

        public const string UNLOCKED            = "U";
        public const string LOCKED              = "L";
    }
}