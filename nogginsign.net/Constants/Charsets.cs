namespace NogginSign.net.Constants
{
    /// <summary>
    /// 
    /// </summary>
    /// <example>
    /// msg = alphasign.Text("%sthis is wide" % alphasign.charsets.FIVE_WIDE, label="A")
    /// </example>
    public static class Charsets
    {
        // Character sets
        public const string FIVE_HIGH_STD         = "\x1A1";
        public const string FIVE_STROKE           = "\x1A2";
        public const string SEVEN_HIGH_STD        = "\x1A3";
        public const string SEVEN_STROKE          = "\x1A4";
        public const string SEVEN_HIGH_FANCY      = "\x1A5";
        public const string TEN_HIGH_STD          = "\x1A6";
        public const string SEVEN_SHADOW          = "\x1A7";
        public const string FULL_HEIGHT_FANCY     = "\x1A8";
        public const string FULL_HEIGHT_STD       = "\x1A9";
        public const string SEVEN_SHADOW_FANCY    = "\x1A:";
        public const string FIVE_WIDE             = "\x1A;";
        public const string SEVEN_WIDE            = "\x1A<";
        public const string SEVEN_FANCY_WIDE      = "\x1A=";
        public const string WIDE_STROKE_FIVE      = "\x1A>";

        // Alpha 2.0 and 3.0 only
        public const string FIVE_HIGH_CUST        = "\x1AW";
        public const string SEVEN_HIGH_CUST       = "\x1AX";
        public const string TEN_HIGH_CUST         = "\x1AY";
        public const string FIFTEEN_HIGH_CUST     = "\x1AZ";

        // Character attributes
        public const string WIDE_ON               = "\x1D01";
        public const string WIDE_OFF              = "\x1D00";
        public const string DOUBLE_WIDE_ON        = "\x1D11";
        public const string DOUBLE_WIDE_OFF       = "\x1D10";
        public const string DOUBLE_HIGH_ON        = "\x1D21";
        public const string DOUBLE_HIGH_OFF       = "\x1D20";
        public const string TRUE_DESCENDERS_ON    = "\x1D31";
        public const string TRUE_DESCENDERS_OFF   = "\x1D30";
        public const string FIXED_WIDTH_ON        = "\x1D41";
        public const string FIXED_WIDTH_OFF       = "\x1D40";
        public const string FANCY_ON              = "\x1D51";
        public const string FANCY_OFF             = "\x1D50";
        public const string AUXILIARY_PORT_ON     = "\x1D61";
        public const string AUXILIARY_PORT_OFF    = "\x1D60";
        public const string SHADOW_CHARACTERS_ON  = "\x1D71";
        public const string SHADOW_CHARACTERS_OFF = "\x1D70";

        public const string FLASH_ON              = "\x071";
        public const string FLASH_OFF             = "\x070";

        // Character spacing
        public const string PROPORTIONAL          = "\x1E0";
        public const string FIXED_WIDTH           = "\x1E1";
    }
}