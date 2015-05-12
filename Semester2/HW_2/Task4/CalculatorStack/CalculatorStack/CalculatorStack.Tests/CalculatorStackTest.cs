using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorStack.Tests
{
    [TestClass]
    public class CalculatorStackTest
    {
        [TestMethod]
        public void StackArrayTest()
        {
            var stack = new StackArray<int>();
            var calculator = new CalculatorStack(stack);
            calculator.AddValue("7");
            calculator.AddValue("6");
            calculator.AddValue("5");
            calculator.AddValue("4");
            calculator.AddValue("*");
            calculator.AddValue("-");
            calculator.AddValue("/");
            Assert.AreEqual(2, calculator.TakeCurrentExpression());
        }

        [TestMethod]
        public void StackListTest()
        {
            var stack = new StackList<int>();
            var calculator = new CalculatorStack(stack);
            calculator.AddValue("7");
            calculator.AddValue("6");
            calculator.AddValue("5");
            calculator.AddValue("4");
            calculator.AddValue("*");
            calculator.AddValue("-");
            calculator.AddValue("/");
            Assert.AreEqual(2, calculator.TakeCurrentExpression());
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivineByZeroTest()
        {
            var stack = new StackArray<int>();
            var calculator = new CalculatorStack(stack);
            calculator.AddValue("0");
            calculator.AddValue("-5");
            calculator.AddValue("/");
        }

        [TestMethod]
        [ExpectedException(typeof(ExtractFromEmptyStackException))]
        public void EmptyStackTest()
        {
            var stack = new StackList<int>();
            var calculator = new CalculatorStack(stack);
            calculator.AddValue("22");
            calculator.AddValue("+");
        }

        [TestMethod]
        [ExpectedException(typeof(AddedWrongValueToCalc))]
        public void WrongFormatTest()
        {
            var stack = new StackArray<int>();
            var calculator = new CalculatorStack(stack);
            calculator.AddValue("haha23");
        }
    }
}