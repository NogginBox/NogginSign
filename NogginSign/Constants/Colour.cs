using NogginSign.Exceptions;
using System.Text.RegularExpressions;

namespace NogginSign.Constants
{
    class Colour
    {
        // Colours
        public const string Red       = "\x1C1";
        public const string Green     = "\x1C2";
        public const string Amber     = "\x1C3";
        public const string DimRed   = "\x1C4";
        public const string DimGreen = "\x1C5";
        public const string Brown     = "\x1C6";
        public const string Orange    = "\x1C7";
        public const string Yellow    = "\x1C8";
        public const string Rainbow1 = "\x1C9";
        public const string Rainbow2 = "\x1CA";
        public const string ColourMix = "\x1CB";
        public const string AutoColour = "\x1CC";

        /// <summary>
        /// Create color constant for use in TEXT and STRING files.
        /// </summary>
        /// <param name="rgb">6-character hex string in form RRGGBB.</param>
        public static string Rgb(string rgb)
        {
            CheckValidRgg(rgb);
			return DimGreen; //$"\x1CZ{rgb}";
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
