using System;
using System.Collections.Generic; 

namespace MoreRomanNumerals.Library
{
    public class Converter
    {
        public static string Convert(int input)
        {
            string output = "";
            if (input == 10) 
            {
                output = "X";
            }
            else if (input >= 9)
            {
                output = "IX";
            }
            else if (input >= 5)
            {
                output = "V" + Convert(input - 5);
            }
            else if (input >= 4)
            {
                output = "IV";
            }
            else if (input >= 1)
            {
                output = "I" + Convert(input - 1); 
            }
            return output; 
        }
    }
}
