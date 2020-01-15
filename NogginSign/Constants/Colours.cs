using NogginSign.Exceptions;
using System.Text.RegularExpressions;

namespace NogginSign.Constants
{
    class Colours
    {
        // Colours
        public const string RED       = "\x1C1";
        public const string GREEN     = "\x1C2";
        public const string AMBER     = "\x1C3";
        public const string DIM_RED   = "\x1C4";
        public const string DIM_GREEN = "\x1C5";
        public const string BROWN     = "\x1C6";
        public const string ORANGE    = "\x1C7";
        public const string YELLOW    = "\x1C8";
        public const string RAINBOW_1 = "\x1C9";
        public const string RAINBOW_2 = "\x1CA";
        public const string COLOR_MIX = "\x1CB";
        public const string AUTOCOLOR = "\x1CC";

        /// <summary>
        /// Create color constant for use in TEXT and STRING files.
        /// </summary>
        /// <param name="rgb">6-character hex string in form RRGGBB.</param>
        public static string Rgb(string rgb)
        {
            CheckValidRgg(rgb);
            return $"\x1CZ{rgb}";
        }

        /// <summary>
        /// Create shadow color constant for use in TEXT and STRING files.
        /// </summary>
        /// <param name="rgb">6-character hex string in form RRGGBB.</param>
        public static string ShadowRgb(string rgb)
        {
            CheckValidRgg(rgb);
            return $"\x1CY{rgb}";
        }
  
        private static void CheckValidRgg(string rgb)
        {
            var isValid = Regex.IsMatch(rgb, "");
            if(!isValid)
            {
                throw new SignColourException();
            }
        }

    }
}
