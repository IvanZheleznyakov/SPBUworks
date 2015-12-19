using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    /// <summary>
    /// Macintosh OS.
    /// </summary>
    public class MacOs : OperatingSystem
    {
        public MacOs()
        {
            ProbabilityOfInfection = 0.5;
        }
    }
}
