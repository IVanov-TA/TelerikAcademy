using System;
using CountNumberInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountNumberInArrayTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            int[] array = new int[0];
            int number = 3;
            int result = Program.GetNumberCount(array, number);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] array = { 1, 1, 1, 1, 1, 1, 4, 4, 4, int.MaxValue };
            int number = 1;
            int result = Program.GetNumberCount(array, number);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] array = { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue };
            int number = int.MaxValue;
            int result = Program.GetNumberCount(array, number);
            Assert.AreEqual(4, result);
        }
    }
}
