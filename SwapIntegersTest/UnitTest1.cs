using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwapIntegers;
namespace SwapIntegersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1, y = 3;
            int X = 3, Y = 1;

            IntSwap.Swap(ref x, ref y);
            Assert.AreEqual(x, X);
            Assert.AreEqual(y, Y);
        }
    }
}
