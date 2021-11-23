using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassISBN;

namespace TestProjectISBN
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodISBN()
        {
            int[] number = new int[] { 0, 7, 1, 6, 7, 0, 3, 4, 4, 0 };

            bool result = ClassIsbn.VerifyISBN(number);

            Assert.AreEqual(true, result);

        }
    }
}
