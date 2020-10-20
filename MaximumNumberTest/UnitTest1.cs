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

        public void GivenMaxValueAtFirstPlace_WhenChecked_Should_ReturnFirstNumber(int num1, int num2, int num3)
        {
            var expected = num1;
            int actual = MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(14,23, 8)]
        [DataRow(65, 985, 74)]

        public void GivenMaxValueAtSecondPlace_WhenChecked_Should_ReturnSecondNumber(int num1, int num2, int num3)
        {
            var expected = num2;
            int actual = MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(14, 8, 23)]
        [DataRow(65, 74, 985)]

        public void GivenMaxValueAtThirdPlace_WhenChecked_Should_ReturnThirdNumber(int num1, int num2, int num3)
        {
            var expected = num3;
            int actual = MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3);
            Assert.AreEqual(expected, actual);
        }
    }

}
