using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace specshell.software.omnic.dde.tests
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        [ExpectedException(typeof(NDde.DdeException))]
        public void TestConnectionException()
        {
            Dde dde = new Dde();
            dde.Connect();
            CommandResponse commandResponse = dde.CommandsHandler.About();
            Assert.IsTrue(commandResponse.ConnectionError());
        }
    }
}
