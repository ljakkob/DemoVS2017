using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(1 == 2);
        }

        [Test]
        public void TestMethod2()
        {
            Assert.IsTrue(1 == 1);
        }
    }
}