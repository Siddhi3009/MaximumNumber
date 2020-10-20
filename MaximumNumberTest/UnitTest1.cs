using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetMaximumNumber;
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
    }

}
