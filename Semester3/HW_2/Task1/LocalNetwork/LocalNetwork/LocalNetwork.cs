using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalNetwork
{
    /// <summary>
    /// Model of local network.
    /// </summary>
    public class LocalNetwork
    {
        public LocalNetwork()
        {
            computers = new List<Computer>();
            linksBetweenComputers = new List<List<bool>>();
        }

        /// <summary>
        /// Add new computer to network.
        /// </summary>
        /// <param name="newComputer"></param>
        public void AddComputer(Computer newComputer)
        {
            computers.Add(newComputer);
            linksBetweenComputers.Add(new List<bool>());
            linksBetweenComputers[linksBetweenComputers.Capacity].Add(false);
        }

        /// <summary>
        /// Add new link between computers.
        /// </summary>
        /// <param name="i">Index of first computer.</param>
        /// <param name="j">Index of second computer.</param>
        public void AddLink(int i, int j)
        {
            if (i <= computers.Capacity && j <= computers.Capacity)
            {
                linksBetweenComputers[i][j] = true;
            }
        }

        private List<Computer> computers;
        private List<List<bool>> linksBetweenComputers;
    }
}
