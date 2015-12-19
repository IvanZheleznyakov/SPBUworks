using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    /// <summary>
    /// Linux operating system.
    /// </summary>
    public class LinuxOs : OperatingSystem
    {
        public LinuxOs()
        {
            ProbabilityOfInfection = 0.4;
        }
    }
}
