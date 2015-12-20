using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocalNetwork.Tests
{
    [TestClass]
    public class LocalNetworkTests
    {
        [TestMethod]
        [ExpectedException(typeof(WrongLinksAddedException))]
        public void LinksExceptionTest()
        {
            LocalNetwork network = new LocalNetwork();
            network.AddComputer(new Computer(new MacOs(), true));
            network.AddLink(0, 1);
        }
    }
}
