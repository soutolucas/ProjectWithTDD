using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectWithTDDTest
{
    using ProjectWithTDD;

    [TestClass]
    public class ConverterRomanNumbersTest
    {
        #region Basic Numbers
        [TestMethod]
        public void ConvertNumberI()
        {
            int number = ConverterRomanNumbers.Convert("I");
            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void ConvertNumberV()
        {
            int number = ConverterRomanNumbers.Convert("V");
            Assert.AreEqual(5, number);
        }

        [TestMethod]
        public void ConvertNumberX()
        {
            int number = ConverterRomanNumbers.Convert("X");
            Assert.AreEqual(10, number);
        }

        [TestMethod]
        public void ConvertNumberL()
        {
            int number = ConverterRomanNumbers.Convert("L");
            Assert.AreEqual(50, number);
        }

        [TestMethod]
        public void ConvertNumberC()
        {
            int number = ConverterRomanNumbers.Convert("C");
            Assert.AreEqual(100, number);
        }

        [TestMethod]
        public void ConvertNumberD()
        {
            int number = ConverterRomanNumbers.Convert("D");
            Assert.AreEqual(500, number);
        }

        [TestMethod]
        public void ConvertNumberM()
        {
            int number = ConverterRomanNumbers.Convert("M");
            Assert.AreEqual(1000, number);
        }
        #endregion

        [TestMethod]
        public void ConvertNumberII()
        {
            int number = ConverterRomanNumbers.Convert("II");
            Assert.AreEqual(2, number);
        }

        [TestMethod]
        public void ConvertNumberIII()
        {
            int number = ConverterRomanNumbers.Convert("III");
            Assert.AreEqual(3, number);
        }

        [TestMethod]
        public void ConvertNumberIV()
        {
            int number = ConverterRomanNumbers.Convert("IV");
            Assert.AreEqual(4, number);
        }

        [TestMethod]
        public void ConvertNumberVI()
        {
            int number = ConverterRomanNumbers.Convert("VI");
            Assert.AreEqual(6, number);
        }

        [TestMethod]
        public void ConvertNumberVII()
        {
            int number = ConverterRomanNumbers.Convert("VII");
            Assert.AreEqual(7, number);
        }

        [TestMethod]
        public void ConvertNumberVIII()
        {
            int number = ConverterRomanNumbers.Convert("VIII");
            Assert.AreEqual(8, number);
        }

        [TestMethod]
        public void ConvertNumberIX()
        {
            int number = ConverterRomanNumbers.Convert("IX");
            Assert.AreEqual(9, number);
        }

        [TestMethod]
        public void ConvertNumberXC()
        {
            int number = ConverterRomanNumbers.Convert("XC");
            Assert.AreEqual(90, number);
        }

        [TestMethod]
        public void ConvertNumberCM()
        {
            int number = ConverterRomanNumbers.Convert("CM");
            Assert.AreEqual(900, number);
        }

        #region Invalid Numbers
        [TestMethod]
        public void ConvertInvalidNumberIIII()
        {
            int number = ConverterRomanNumbers.Convert("IIII");
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void ConvertInvalidNumberIIIV()
        {
            int number = ConverterRomanNumbers.Convert("IIIV");
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void ConvertInvalidNumberIL()
        {
            int number = ConverterRomanNumbers.Convert("IL");
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void ConvertInvalidNumberIC()
        {
            int number = ConverterRomanNumbers.Convert("IC");
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void ConvertInvalidNumberID()
        {
            int number = ConverterRomanNumbers.Convert("ID");
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void ConvertInvalidNumberIM()
        {
            int number = ConverterRomanNumbers.Convert("IM");
            Assert.AreEqual(0, number);
        }
        #endregion
    }
}
