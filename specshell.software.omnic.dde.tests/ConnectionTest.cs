using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace specshell.software.omnic.dde.tests
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void TestConnectionException()
        {
            CommandResponse commandResponse = Commands.About();
            Assert.IsTrue(commandResponse.ConnectionError());
        }
    }
}
