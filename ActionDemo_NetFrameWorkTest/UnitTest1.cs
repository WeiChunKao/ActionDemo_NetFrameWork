using NUnit.Framework;

namespace ActionDemo_NetFrameWorkTest
{
    [TestFixture]
    public class Tests
    {
        [TestCase(1, 1, 2)]
        [TestCase(12, 30, 42)]
        [TestCase(14, 1, 15)]
        public void Test_Add(int a, int b, int expected)
        {
            //===Arrange===
            var actual = a + b;
            //===Assert===
            Assert.AreEqual(expected, actual);
        }
    }
}