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
    public class MortgageTests
    {
        double principal = 1000;
        double interest = 1;
        int term = 10;
        int period = 10;

        [TestMethod()]
        public void MortgageMonthlyPayment()
        {
            Mortgage mortgage = new Mortgage(principal, interest, term, period);
            double expected = 10.51;
            double actual = Math.Round(mortgage.MonthlyPayment(), 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MorgageMonthlyInterestRate()
        {
            Mortgage mortgage = new Mortgage(principal, interest, term, period);
            double testMonthlyInterestRate = 0.001;
            double actual = Math.Round(mortgage.MonthlyInterestRate(interest, period), 4);
            Assert.AreEqual(testMonthlyInterestRate, actual);
        }

        [TestMethod()]
        public void MorgageNumberOfPayments()
        {
            Mortgage mortgage = new Mortgage(principal, interest, term, period);
            int testPayments = 100;
            int actual = mortgage.NumberOfPayments(term, period);
            Assert.AreEqual(testPayments, actual);
        }

        [TestMethod()]
        public void MorgageCompoundedInterestRate()
        {
            Mortgage mortgage = new Mortgage(principal, interest, term, period);
            double monthlyInterestRate = 0.001;
            int numberOfPayments = 100;
            double testCompoundedInterest = 1.1051;
            double actual = Math.Round(mortgage.CompoundedInterestRate(monthlyInterestRate, numberOfPayments), 4);
            Assert.AreEqual(testCompoundedInterest, actual);
        }

        [TestMethod()]
        public void MortgageInterestQuotient()
        {
            Mortgage mortgage = new Mortgage(principal, interest, term, period);
            double monthlyInterestRate = 0.001;
            int numberOfPayments = 100;
            double compoundedInterest = 1.1051;
            double testQuotient = 0.0105;
            double actual = Math.Round(mortgage.InterestQuotient(monthlyInterestRate, compoundedInterest, numberOfPayments), 4);
            Assert.AreEqual(testQuotient, actual);
        }
    }
}