using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeExpression.Tests
{
    [TestClass]
    public class TreeExpressionTest
    {
        [TestMethod]
        public void PrintTreeTest()
        {
            var tree = new Tree();
            string expression = System.IO.File.ReadAllText("expression.txt");
            ReadExpression.ReadExpressionFromString(tree, expression);

            string result = "(((5 + 3) / (2 + 2)) * (7 - 4))";
            Assert.AreEqual(result, tree.PrintTree());
        }

        [TestMethod]
        public void CountTreeTest()
        {
            var tree = new Tree();
            string expression = System.IO.File.ReadAllText("expression.txt");
            ReadExpression.ReadExpressionFromString(tree, expression);

            Assert.AreEqual(6, tree.CountTree());
        }
    }
}
