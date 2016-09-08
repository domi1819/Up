﻿using System;
using System.Drawing;

namespace domi1819.UpCore.Utilities
{
    public static class ExtensionConverters
    {
        public static string Pad(this int value, int length)
        {
            return value.ToString().PadLeft(length, '0');
        }

        public static string ToHex(this byte value)
        {
            return $"{Util.GetHexChar(value >> 4)}{Util.GetHexChar(value)}";
        }

        public static string ToHex(this Color color)
        {
            return $"#{(color.A == 255 ? "" : color.A.ToHex())}{color.R.ToHex()}{color.G.ToHex()}{color.B.ToHex()}";
        }

        public static string FormatString(this DateTime dateTime)
        {
            return $"{dateTime.Year}-{dateTime.Month.Pad(2)}-{dateTime.Day.Pad(2)} {dateTime.Hour.Pad(2)}:{dateTime.Minute.Pad(2)}:{dateTime.Second.Pad(2)}";
        }
    }
}
