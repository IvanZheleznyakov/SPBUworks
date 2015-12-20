using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    /// <summary>
    /// Windows operations system.
    /// </summary>
    public class WindowsOs : OperatingSystem
    {
        public WindowsOs()
        {
            ProbabilityOfInfection = 0.6;
            OSName = "Windows";
        }
    }
}
