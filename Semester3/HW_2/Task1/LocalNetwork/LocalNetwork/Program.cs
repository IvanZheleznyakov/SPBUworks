using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalNetwork network = new LocalNetwork();
            Computer computer0 = new Computer(new MacOs(), true);
            Computer computer1 = new Computer(new WindowsOs(), false);
            Computer computer2 = new Computer(new LinuxOs(), false);
            Computer computer3 = new Computer(new WindowsOs(), false);
            Computer computer4 = new Computer(new LinuxOs(), true);
            network.AddComputer(computer0);
            network.AddComputer(computer1);
            network.AddComputer(computer2);
            network.AddComputer(computer3);
            network.AddComputer(computer4);
            network.AddLink(0, 1);
            network.AddLink(1, 2);
            network.AddLink(2, 3);
            network.AddLink(3, 4);
            network.AddLink(2, 4);
            network.Start();
        }
    }
}
