using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    /// <summary>
    /// Computer with OS.
    /// </summary>
    public class Computer
    {
        public Computer(OperatingSystem operatingSystem, bool isInfected)
        {
            this.operatingSystem = operatingSystem;
            IsInfected = isInfected;
        }

        public OperatingSystem operatingSystem;
        public bool IsInfected { get; set; }
    }
}
