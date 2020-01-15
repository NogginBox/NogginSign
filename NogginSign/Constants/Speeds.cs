namespace NogginSign.Constants
{
    /// <summary>
    /// Change the speed of the text (1 slowest, 5 fastest)
    /// </summary>
    /// <example>
    /// alphasign.Text("%sthis text is fast" % alphasign.speeds.SPEED_5, label="A", mode=alphasign.modes.ROTATE)
    /// </example>
    public static class Speeds
    {
        public const string SPEED_1 = "\x15";
        public const string SPEED_2 = "\x16";
        public const string SPEED_3 = "\x17";
        public const string SPEED_4 = "\x18";
        public const string SPEED_5 = "\x19";
    }
}