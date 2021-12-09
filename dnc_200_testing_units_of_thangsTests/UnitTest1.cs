using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using dnc_200_testing_units_of_thangs;

namespace dnc_200_testing_units_of_thangsTests
{
    [TestClass]
    public class UnitTest1
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

		[TestMethod]
		public void SubtractTest()
		{
			double a = 3f;
			double b = 2f;
			double expectedC = 1f;
			double actualC = calc.Subtract(a, b);
			Assert.AreEqual(expectedC, actualC);
		}

		[TestMethod]
		public void MultiplyTest()
		{
			double a = 3f;
			double b = 2f;
			double expectedC = 6f;
			double actualC = calc.Multiply(a, b);
			Assert.AreEqual(expectedC, actualC);
		}

		[TestMethod]
		public void DivideTest()
		{
			double a = 3f;
			double b = 2f;
			double expectedC = 1.5f;
			double actualC = calc.Divide(a, b);
			Assert.AreEqual(expectedC, actualC);
		}

		[TestMethod]
		public void AddTestOne()
		{
			double a = 3f;
			double b = 3f;
			double expectedC = 6f;
			double actualC = calc.Add(a, b);
			Assert.AreEqual(expectedC, actualC);
		}

		[TestMethod]
		public void SubtractTestOne()
		{
			double a = 3f;
			double b = 3f;
			double expectedC = 0f;
			double actualC = calc.Subtract(a, b);
			Assert.AreEqual(expectedC, actualC);
		}

		[TestMethod]
		public void MultiplyTestOne()
		{
			double a = 3f;
			double b = 3f;
			double expectedC = 9f;
			double actualC = calc.Multiply(a, b);
			Assert.AreEqual(expectedC, actualC);
		}

		[TestMethod]
		public void DivideTestOne()
		{
			double a = 3f;
			double b = 3f;
			double expectedC = 1f;
			double actualC = calc.Divide(a, b);
			Assert.AreEqual(expectedC, actualC);
		}

		// principal = 1000;
		// interest = 1;
		// term = 10;
		// period = 10;
		Mortgage calcOne = new Mortgage(1000, 1, 10, 10);


		[TestMethod]
		public void MonthlyPaymentsTest()
		{
			double expected = 10.51;
			double actual = calcOne.MonthlyPayment();
			Assert.AreEqual(expected, actual);
		}
	}
}
