using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {

        Calculator.CalculatorSoapClient calcref;
        [TestMethod]
        public void TestAdd()
        {

            calcref = new Calculator.CalculatorSoapClient();
            double d = calcref.Add(2.0, 2.0);
            Assert.AreEqual(d, 4.0);

        }
        [TestMethod]
        public void TestMinus()
        {

            calcref = new Calculator.CalculatorSoapClient();
            double d = calcref.Subtrct(4.0, 2.0);
            Assert.AreEqual(d, 2.0);
        }
        [TestMethod]
        public void TestMultiply()
        {

            calcref = new Calculator.CalculatorSoapClient();
            double d = calcref.Multiply(2.0, 2.0);
            Assert.AreEqual(d, 4.0);
        }
        [TestMethod]
        public void TestDivide()
        {

            calcref = new Calculator.CalculatorSoapClient();
            double d = calcref.Divide(4.0, 2.0);
            Assert.AreEqual(d, 2.0);
        }
        [TestMethod]
        public void TestSquareRoot()
        {

            calcref = new Calculator.CalculatorSoapClient();
            double d = calcref.SquareRoot(16.0);
            Assert.AreEqual(d, 4.0);
        }
        [TestMethod]
        public void TestHalf()
        {

            calcref = new Calculator.CalculatorSoapClient();
            double d = calcref.Halve(4.0);
            Assert.AreEqual(d, 2.0);
        }
        [TestMethod]
        public void TestQuarter()

        {

            calcref = new Calculator.CalculatorSoapClient();
            double d = calcref.Quarter(8.0);
            Assert.AreEqual(2.0, d);
        }
           
    }
}
