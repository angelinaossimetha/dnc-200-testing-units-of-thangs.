using Microsoft.VisualStudio.TestTools.UnitTesting;
using dnc_200_testing_units_of_thangs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnc_200_testing_units_of_thangs.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calc = new Calculator();

        [TestMethod()]
        public void AddTest()
        {
            float a = 3f;
            float b = 2f;
            float c = 5f;
            Assert.AreEqual(c, calc.Add(a, b));
        }

        [TestMethod()]
        public void SubtractTest()
        {
            float a = 3f;
            float b = 2f;
            float c = 1f;
            Assert.AreEqual(c, calc.Subtract(a, b));
        }

        [TestMethod()]
        public void DivideTest()
        {
            float a = 3f;
            float b = 2f;
            float c = 1.5f;
            Assert.AreEqual(c, calc.Divide(a, b));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            float a = 3f;
            float b = 2f;
            float c = 6f;
            Assert.AreEqual(c, calc.Multiply(a, b));
        }
    }
}