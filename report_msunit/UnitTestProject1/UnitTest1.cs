using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using report_msunit;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestMethodCalculateSum()
        {
            Calculator cal  = new Calculator();
            int result = cal.Sum(10, 15);

            Assert.AreEqual(25, result);
        }
        [TestMethod]
        public void TestMethodCalculateSubtract()
        {
            Calculator cal = new Calculator();
            int result = cal.Subtract(15, 10);

            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethodCalculateMult()
        {
            Calculator cal = new Calculator();
            int result = cal.Mult(2, 10);

            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void TestMethodCalculateDivision()
        {
            Calculator cal = new Calculator();
            double result = cal.Division(2, 10);

            Assert.AreEqual(0.2, result);
        }
    }
}
