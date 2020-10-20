using GetMaximumNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MaximumNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(23, 14, 8)]
        [DataRow(985, 65, 74)]

        public void GivenMaxValueAtFirstPlace_WhenCheckedInMaximumIntegerNumber_ShouldReturnFirstNumber(int num1, int num2, int num3)
        {
            var expected = num1;
            int actual = MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(14,23, 8)]
        [DataRow(65, 985, 74)]

        public void GivenMaxValueAtSecondPlace_WhenCheckedInMaximumIntegerNumber_ShouldReturnSecondNumber(int num1, int num2, int num3)
        {
            var expected = num2;
            int actual = MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(14, 8, 23)]
        [DataRow(65, 74, 985)]

        public void GivenMaxValueAtThirdPlace_WhenCheckedInMaximumIntegerNumber_ShouldReturnThirdNumber(int num1, int num2, int num3)
        {
            var expected = num3;
            int actual = MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(14.89F, 8.85F, 23.6F)]
        [DataRow(65.56F, 65.53F, 985.23F)]

        public void GivenMaxValueAtThirdPlace_WhenCheckedInMaximumFloatNumber_ShouldReturnThirdNumber(float num1, float num2, float num3)
        {
            float expected = num3;
            float actual = MaximumNumberCheck.MaximumFloatNumber(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(8.3F, 23.56F, 14.65F)]
        [DataRow(65.89F, 985.85F, 65.96F)]

        public void GivenMaxValueAtSecondPlace_WhenCheckedInMaximumFloatNumber_ShouldReturnSecondNumber(float num1, float num2, float num3)
        {
            float expected = num2;
            float actual = MaximumNumberCheck.MaximumFloatNumber(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(23.56F, 8.58F, 14.96F)]
        [DataRow(985.85F, 65.96F, 65.7F)]

        public void GivenMaxValueAtFirstPlace_WhenCheckedInMaximumFloatNumber_ShouldReturnFirstNumber(float num1, float num2, float num3)
        {
            float expected = num1;
            float actual = MaximumNumberCheck.MaximumFloatNumber(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("9", "14", "8")]
        [DataRow("99", "65", "74")]

        public void GivenMaxValueAtFirstPlace_WhenCheckedInMaximumString_ShouldReturnFirstNumber(string string1, string string2, string string3)
        {
            string expected = string1;
            string actual = MaximumNumberCheck.MaximumString(string1, string2, string3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("14", "9", "8")]
        [DataRow("65", "99", "74")]

        public void GivenMaxValueAtSecondPlace_WhenCheckedInMaximumString_ShouldReturnSecondNumber(string string1, string string2, string string3)
        {
            string expected = string2;
            string actual = MaximumNumberCheck.MaximumString(string1, string2, string3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("14", "8", "99")]
        [DataRow("65", "74", "9")]

        public void GivenMaxValueAtThirdPlace_WhenCheckedInMaximumString_ShouldReturnThirdNumber(string string1, string string2, string string3)
        {
            string expected = string3;
            string actual = MaximumNumberCheck.MaximumString(string1, string2, string3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("9", "14", "8")]
        [DataRow("99", "65", "74")]

        public void GivenMaxValueAtFirstPlace_WhenCheckedInMaximumCheck_ShouldReturnFirstValue(string num1, string num2, string num3)
        {
            string expected = num1;
            string actual = MaximumNumberCheck.MaximumCheck<string>(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(9, 14, 8)]
        [DataRow(65, 99, 74)]

        public void GivenMaxValueAtSecondPlace_WhenCheckedInMaximumCheck_ShouldReturnSecondValue(int num1, int num2, int num3)
        {
            int expected = num2;
            int actual = MaximumNumberCheck.MaximumCheck<int>(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(14.23F, 8.36F, 99.99F)]
        [DataRow(65.36F, 9.56F, 74.56F)]

        public void GivenMaxValueAtThirdPlace_WhenCheckedInMaximumCheck_ShouldReturnThirdValue(float num1, float num2, float num3)
        {
            float expected = num3;
            float actual = MaximumNumberCheck.MaximumCheck<float>(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
    }

}
