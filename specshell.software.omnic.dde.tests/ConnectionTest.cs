using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace specshell.software.omnic.dde.tests
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void TestConnectionException()
        {
            Dde dde = new Dde();
            dde.Connect();
            CommandResponse commandResponse = dde.CommandsHandler.About();
            Assert.IsTrue(commandResponse.ConnectionError());
        }
    }
}
