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
            double a = 3f;
            double b = 2f;
            double expectedC = 5f;

            double actualC = calc.Add(a, b);

            Assert.AreEqual(expectedC, actualC);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            double a = 3f;
            double b = 2f;
            double expectedC = 1f;

            double actualC = calc.Subtract(a, b);

            Assert.AreEqual(expectedC, actualC);
        }

        [TestMethod()]
        public void DivideTest()
        {
            double a = 3f;
            double b = 2f;
            double expectedC = 1.5f;

            double actualC = calc.Divide(a, b);

            Assert.AreEqual(expectedC, actualC);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            double a = 3f;
            double b = 2f;
            double expectedC = 6f;

            double actualC = calc.Multiply(a, b);

            Assert.AreEqual(expectedC, actualC);
        }
    }
}