using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace specshell.software.omnic.dde.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Hurray - message from test method 1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Waddup - message from test method 2 - build to fail");
            Assert.IsTrue(8 >= 10);
        }
    }
}
