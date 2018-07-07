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

        [Test()]
        public void ReturnsV_When5()
        {
            int input = 5;
            string output = Converter.Convert(input);
            Assert.AreEqual("V", output);
        }

        [Test()]
        public void ReturnsVI_When6()
        {
            int input = 6;
            string output = Converter.Convert(input);
            Assert.AreEqual("VI", output);
        }

        [Test()]
        public void ReturnsX_When10()
        {
            int input = 10;
            string output = Converter.Convert(input);
            Assert.AreEqual("X", output);
        }

        [Test()]
        public void ReturnsIX_When9()
        {
            int input = 9;
            string output = Converter.Convert(input);
            Assert.AreEqual("IX", output);
        }

        [Test()]
        public void ReturnsXI_When11()
        {
            int input = 11;
            string output = Converter.Convert(input);
            Assert.AreEqual("XI", output); 
        }

        [Test()]
        public void ReturnsXLI_When()
        {
            int input = 41;
            string output = Converter.Convert(input);
            Assert.AreEqual("XLI", output);
        }

    }
}
