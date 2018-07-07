using System;
using System.Collections.Generic; 

namespace MoreRomanNumerals.Library
{
    public class Converter
    {
        public static string Convert(int input)
        {
            string output = new string('I', input);
            if (input == 4)
            {
                output = "IV";
            }
            else if (input == 5)
            {
                output = "V";
            }
            else if (input > 5 && input < 9)
            {
                var remainder = input % 5;
                output = "V" + new string('I', remainder);
            }
            else if (input == 10)
            {
                output = "X";
            }
            else
            {
                return output;
            }
            return output;
        }
    }
}
