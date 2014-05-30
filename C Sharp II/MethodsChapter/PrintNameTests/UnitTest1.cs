using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingName;
namespace PrintNameTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] names = { "Ivan", "Dragan", "Pesho", "Mima", "" };

            foreach (var name in names)
            {
                string value = Program.PrintName(name);
                string testSentence = "Hello " + name;
                Assert.AreEqual(testSentence, value);
            }


        }
    }
}
