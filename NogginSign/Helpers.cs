﻿using System.Linq;

namespace NogginSign
{
    internal static class Helpers
    {
        public static string Repeat(this string value, int times)
        {
            return string.Concat(Enumerable.Repeat(value, times));
        }
    }
}