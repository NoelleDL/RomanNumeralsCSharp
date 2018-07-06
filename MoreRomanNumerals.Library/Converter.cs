using System;

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
            return output;
        }
    }
}
