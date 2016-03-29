using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectWithTDDTest
{
    using ProjectWithTDD;

    [TestClass]
    public class ConverterTest
    {
        #region TryParseInt
        [TestMethod]
        public void TryParseIntWithStringBroken()
        {
            int number;
            bool result = Converter.TryParseInt("1000000000 0", out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseIntWithStringEmpty()
        {
            int number;
            bool result = Converter.TryParseInt("", out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseIntWithStringSpace()
        {
            int number;
            bool result = Converter.TryParseInt("       ", out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseIntWithStringLetters()
        {
            int number;
            bool result = Converter.TryParseInt("asdasdasd", out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseIntWithStringNull()
        {
            int number;
            bool result = Converter.TryParseInt(null, out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseIntWithStringNumber()
        {
            int number;
            bool result = Converter.TryParseInt("2132131232", out number);
            Assert.AreEqual(2132131232, number);
            Assert.IsTrue(result);
        }
        #endregion

        #region TryParseInt2
        [TestMethod]
        public void TryParseInt2WithStringBroken()
        {
            int number;
            bool result = Converter.TryParseInt2("1000000000 0", out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseInt2WithStringEmpty()
        {
            int number;
            bool result = Converter.TryParseInt2("", out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseInt2WithStringSpace()
        {
            int number;
            bool result = Converter.TryParseInt2("       ", out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseInt2WithStringLetters()
        {
            int number;
            bool result = Converter.TryParseInt2("asdasdasd", out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseInt2WithStringNull()
        {
            int number;
            bool result = Converter.TryParseInt2(null, out number);
            Assert.AreEqual(0, number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TryParseInt2WithStringNumber()
        {
            int number;
            bool result = Converter.TryParseInt2("2132131232", out number);
            Assert.AreEqual(2132131232, number);
            Assert.IsTrue(result);
        }
        #endregion
    }
}
