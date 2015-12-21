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

        [TestMethod]
        [ExpectedException(typeof(AddInfoDuringWorking))]
        public void AddInfoExceptionTest()
        {
            LocalNetwork network = new LocalNetwork();
            network.AddComputer(new Computer(new WindowsOs(), false));
            network.Step();
            network.AddComputer(new Computer(new LinuxOs(), true));
        }

        [TestMethod]
        public void OneHundredPercentProbabilityTest()
        {
            LocalNetwork network = new LocalNetwork();
            LinuxOs linux = new LinuxOs(1);
            WindowsOs windows = new WindowsOs(1);
            network.AddComputer(new Computer(linux, true));
            network.AddComputer(new Computer(windows, false));
            network.AddComputer(new Computer(linux, false));
            network.AddComputer(new Computer(windows, false));
            network.AddComputer(new Computer(windows, false));
            network.AddComputer(new Computer(linux, true));
            network.AddLink(0, 1);
            network.AddLink(1, 2);
            network.AddLink(2, 3);
            network.AddLink(3, 4);
            network.AddLink(4, 5);
            network.Step();
            Assert.AreEqual(4, network.InfectedComputers);
            network.Step();
            Assert.AreEqual(6, network.InfectedComputers);
        }

        [TestMethod]
        public void NoChanceToInfectTest()
        {
            LocalNetwork network = new LocalNetwork();
            MacOs mac = new MacOs(0);
            WindowsOs windows = new WindowsOs(0);
            network.AddComputer(new Computer(mac, true));
            network.AddComputer(new Computer(windows, false));
            network.AddComputer(new Computer(mac, false));
            network.AddComputer(new Computer(windows, false));
            network.AddComputer(new Computer(windows, false));
            network.AddComputer(new Computer(mac, true));
            network.AddLink(0, 1);
            network.AddLink(1, 2);
            network.AddLink(2, 3);
            network.AddLink(3, 4);
            network.AddLink(4, 5);
            network.Step();
            Assert.AreEqual(2, network.InfectedComputers);
            network.Step();
            Assert.AreEqual(2, network.InfectedComputers);
            network.Step();
            network.Step();
            network.Step();
            network.Step();
            network.Step();
            Assert.AreEqual(2, network.InfectedComputers);
        }
    }
}
