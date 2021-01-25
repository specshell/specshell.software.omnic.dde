using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Specshell.OmnicDde.Tests
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestConnectionException()
        {
            var client = new OmnicDdeClient();
            client.About();
            client.Connect();
        }
    }
}
