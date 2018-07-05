using NUnit.Framework; 
using System;


namespace MoreRomanNumerals.Library.Tests
{
    [TestFixture()]
    public class ConverterTests
    {
        [Test()]
        public void ReturnsI_When1()
        {
            int input = 1;
            string output = Converter.Convert(input);
            Assert.AreEqual("I", output);
        }

        [Test()]
        public void ReturnsII_When2()
        {
            int input = 2;
            string output = Converter.Convert(input);
            Assert.AreEqual("II", output);
        }

        [Test()]
        public void ReturnsIV_When4()
        {
            int input = 4;
            string output = Converter.Convert(input);
            Assert.AreEqual("IV", output);
        }
    }
}
