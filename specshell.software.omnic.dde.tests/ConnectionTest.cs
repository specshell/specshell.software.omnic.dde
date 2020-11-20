using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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
        }
    }
}
