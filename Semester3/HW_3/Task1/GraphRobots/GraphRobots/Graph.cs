using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphRobots
{
    /// <summary>
    /// Class which realized graph with robots in some nodes.
    /// </summary>
    public class Graph
    {
        public Graph(int numOfNodes)
        {
            graph = new List<List<int>>();
            robotPositions = new List<int>();
            canBeDestroyed = new List<int>();

            for (int i = 0; i != numOfNodes; ++i)
            {
                graph.Add(new List<int>());
            }
        }

        /// <summary>
        /// Add edge between two nodes.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void AddEdge(int i, int j)
        {
            graph[i].Add(j);
            graph[j].Add(i);
        }

        /// <summary>
        /// Add robot to graph's node.
        /// </summary>
        /// <param name="node"></param>
        public void AddRobot(int node)
        {
            if (!robotPositions.Contains(node))
            {
                robotPositions.Add(node);
            }
        }

        /// <summary>
        /// Check if all robots can be destroyed.
        /// </summary>
        /// <returns></returns>
        public bool AreAllRobotsDestroyed()
        {
            if (robotPositions.Count % 2 != 0)
            {
                return false;
            }

            canBeDestroyed.Clear();

            for (int i = 0; i != robotPositions.Count; ++i)
            {
                if (!canBeDestroyed.Contains(robotPositions[i]))
                {
                    bool[] isVisited = new bool[graph.Count];
                    if (!FindAnotherRobotToDestroy(robotPositions[i], ref isVisited, false))
                    {
                        return false;
                    }
                    else
                    {
                        canBeDestroyed.Add(robotPositions[i]);
                    }
                }
            }

            return true;
        }

        private bool FindAnotherRobotToDestroy(int currentNode, ref bool[] isVisited, bool canJumpNow)
        {
            if (!canJumpNow)
            {
                isVisited[currentNode] = true;
                if (robotPositions.Contains(currentNode))
                {
                    canBeDestroyed.Add(currentNode);
                    return true;
                }
                else
                {
                    for (int i = 0; i != graph[currentNode].Count; ++i)
                    {
                        if (!isVisited[graph[currentNode][i]])
                        {
                            if (FindAnotherRobotToDestroy(graph[currentNode][i], ref isVisited, true))
                            {
                                return true;
                            }
                        }
                    }

                    return false;
                }
            }
            else
            {
                for (int i = 0; i != graph[currentNode].Count; ++i)
                {
                    if (!isVisited[graph[currentNode][i]])
                    {
                        if (FindAnotherRobotToDestroy(graph[currentNode][i], ref isVisited, false))
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        }

        private List<int> robotPositions;
        private List<int> canBeDestroyed;
        private List<List<int>> graph;
    }
}
