using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Specshell.OmnicDde
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
        }
    }
}
