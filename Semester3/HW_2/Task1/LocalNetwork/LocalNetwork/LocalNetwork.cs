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
            if (newComputer.IsInfected)
            {
                ++infectedComputers;
            }
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
                linksBetweenComputers[j][i] = true;
            }
        }

        /// <summary>
        /// Start work.
        /// </summary>
        public void Start()
        {
            while (infectedComputers != computers.Capacity)
            {
                Step();
            }
        }

        /// <summary>
        /// Step of infection algorithm.
        /// </summary>
        private void Step()
        {
            List<int> willBeInfected = new List<int>();
            for (int i = 0; i != computers.Capacity; ++i)
            {
                if (!computers[i].IsInfected)
                {
                    for (int j = 0; j != computers.Capacity; ++j)
                    {
                        if (linksBetweenComputers[i][j] && computers[j].IsInfected)
                        {
                            if (RandomSingleton.GetInstance().NextDouble() <= computers[i].operatingSystem.ProbabilityOfInfection)
                            {
                                willBeInfected.Add(i);
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i != willBeInfected.Capacity; ++i)
            {
                computers[willBeInfected[i]].IsInfected = true;
                ++infectedComputers;
            }
        }

        /// <summary>
        /// Show state of network.
        /// </summary>
        private void ShowState()
        {
            for (int i = 0; i != computers.Capacity; ++i)
            {
                string state = i.ToString() + " computer with " + computers[i].operatingSystem.OSName +" is";
                if (!computers[i].IsInfected)
                {
                    state += " not ";
                }
                state += "infected";
                Console.WriteLine(state);
            }
            Console.WriteLine();
        }

        private List<Computer> computers;
        private List<List<bool>> linksBetweenComputers;
        private int infectedComputers = 0;
    }
}
