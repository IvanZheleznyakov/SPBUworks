using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GraphRobots.Tests
{
    [TestClass]
    public class GraphRobotsTest
    {
        [TestMethod]
        public void ThreeRobotsTest()
        {
            Graph graph = new Graph(5);
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);
            graph.AddEdge(2, 4);
            graph.AddRobot(0);
            graph.AddRobot(2);
            graph.AddRobot(4);
            Assert.AreEqual(false, graph.AreAllRobotsDestroyed());
        }

        [TestMethod]
        public void FullGraphTest()
        {
            Graph graph = new Graph(6);
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 5);
            graph.AddEdge(5, 3);
            graph.AddEdge(0, 5);
            for (int i = 0; i != 6; ++i)
            {
                graph.AddRobot(i);
            }

            Assert.AreEqual(true, graph.AreAllRobotsDestroyed());
        }

        [TestMethod]
        public void FourRobotsTest()
        {
            Graph graph = new Graph(11);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 4);
            graph.AddEdge(1, 5);
            graph.AddEdge(2, 5);
            graph.AddEdge(3, 6);
            graph.AddEdge(4, 7);
            graph.AddEdge(4, 8);
            graph.AddEdge(5, 9);
            graph.AddEdge(8, 9);
            graph.AddEdge(9, 10);
            graph.AddRobot(0);
            graph.AddRobot(2);
            graph.AddRobot(4);
            graph.AddRobot(6);

            Assert.AreEqual(true, graph.AreAllRobotsDestroyed());
        }
    }
}
