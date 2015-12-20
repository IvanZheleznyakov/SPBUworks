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
        public WindowsOs(double probability = 0.6)
        {
            ProbabilityOfInfection = probability;
            OSName = "Windows";
        }
    }
}
