using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    /// <summary>
    /// Abstract class for operation systems.
    /// </summary>
    public abstract class OperatingSystem
    {
        public double ProbabilityOfInfection { get; protected set; }
        public string OSName { get; protected set; }
    }
}
