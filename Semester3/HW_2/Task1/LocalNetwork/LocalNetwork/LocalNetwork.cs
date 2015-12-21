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
            IsWorking = false;
        }

        /// <summary>
        /// Add new computer to network.
        /// </summary>
        /// <param name="newComputer"></param>
        public void AddComputer(Computer newComputer)
        {
            if (IsWorking)
            {
                throw new AddInfoDuringWorking();
            }

            computers.Add(newComputer);
            linksBetweenComputers.Add(new List<bool>());
            for (int i = 0; i != linksBetweenComputers.Count; ++i)
            {
                if (i == linksBetweenComputers.Count - 1)
                {
                    for (int j = 0; j != linksBetweenComputers.Count - 1; ++j)
                    {
                        linksBetweenComputers[j].Add(false);
                    }
                }
                linksBetweenComputers[linksBetweenComputers.Count - 1].Add(false);
            }

            if (newComputer.IsInfected)
            {
                ++InfectedComputers;
            }
        }

        /// <summary>
        /// Add new link between computers.
        /// </summary>
        /// <param name="i">Index of first computer.</param>
        /// <param name="j">Index of second computer.</param>
        public void AddLink(int i, int j)
        {
            if (IsWorking)
            {
                throw new AddInfoDuringWorking();
            }

            if (i > computers.Count - 1 || j > computers.Count - 1)
            {
                throw new WrongLinksAddedException();
            }

            linksBetweenComputers[i][j] = true;
            linksBetweenComputers[j][i] = true;
        }

        /// <summary>
        /// Start auto-working.
        /// </summary>
        public void Start()
        {
            ShowState();
            while (InfectedComputers != computers.Count)
            {
                Step();
            }
        }

        /// <summary>
        /// Step of infection algorithm.
        /// </summary>
        public void Step()
        {
            IsWorking = true;
            List<int> willBeInfected = new List<int>();
            for (int i = 0; i != computers.Count; ++i)
            {
                if (!computers[i].IsInfected)
                {
                    for (int j = 0; j != computers.Count; ++j)
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

            for (int i = 0; i != willBeInfected.Count; ++i)
            {
                computers[willBeInfected[i]].IsInfected = true;
                ++InfectedComputers;
            }

            if (InfectedComputers == computers.Count)
            {
                IsWorking = false;
            }

            ShowState();
        }

        /// <summary>
        /// Show state of network.
        /// </summary>
        private void ShowState()
        {
            for (int i = 0; i != computers.Count; ++i)
            {
                string state = i.ToString() + " computer with " + computers[i].operatingSystem.OSName +" is";
                if (!computers[i].IsInfected)
                {
                    state += " not";
                }
                state += " infected";
                Console.WriteLine(state);
            }
            Console.WriteLine();
        }

        private List<Computer> computers;
        private List<List<bool>> linksBetweenComputers;
        public int InfectedComputers { get; private set; }
        public bool IsWorking { get; private set; }
    }
}
