using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToBinary
{
    public static class StringExtensions
    {
        public static string ToBinary(this string text)
        {
            return ToBinary(text, BinaryType.ascii);
        }

        public static string ToBinary(this string text, BinaryType type)
        {
            return ToBinary(text, type, true);
        }

        public static string ToBinary(this string text, bool fullTranslate)
        {
            return ToBinary(text, BinaryType.ascii, fullTranslate);
        }

        public static string ToBinary(this string text, BinaryType type, bool fullTranslate)
        {
            switch (type)
            {
                case BinaryType.ascii:
                default:
                    return text.ToAscii(fullTranslate);
            }
        }
    }

    public enum BinaryType
    {
        ascii
    }
}
