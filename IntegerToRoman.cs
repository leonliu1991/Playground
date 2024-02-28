﻿using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class IntegerToRoman
    {
        public string ConvertIntegerToRoman(int num)
        {
            var romanNumberBuilder = new StringBuilder();
            var romansMap = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };

            foreach (var romanInt in romansMap.Keys)
            {
                while (romanInt <= num)
                {
                    romanNumberBuilder.Append(romansMap[romanInt]);
                    num -= romanInt;
                }
            }

            var romanNumber = romanNumberBuilder.ToString();
            return romanNumber;
        }
    }
}
