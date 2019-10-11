using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnc_200_testing_units_of_thangs
{
    public class Mortgage
    {
        public double principal { get; set; }
        public double interest { get; set; }
        public int term { get; set; }
        public int period { get; set; }

        public Mortgage(double principal, double interest, int term, int period)
        {
            this.principal = principal;
            this.interest = interest;
            this.term = term;
            this.period = period;
        }

        public double MonthlyPayment()
        {
            double monthlyInterestRate = MonthlyInterestRate(interest, period);
            int numberOfPayments = NumberOfPayments(term, period);
            double compoundedInterestRate = CompoundedInterestRate(monthlyInterestRate, numberOfPayments);
            double interestQuotient = InterestQuotient(monthlyInterestRate, compoundedInterestRate, numberOfPayments);
            double monthlyPayment = principal * interestQuotient;
            return monthlyPayment;
        }

        public double MonthlyInterestRate(double interest, int period)
        {
            return (interest / (period * 100));
        }

        public int NumberOfPayments(int term, int period)
        {
            return term * period;
        }

        public double CompoundedInterestRate(double monthlyInterestRate, int numberOfPayments)
        {
            return Math.Pow(1 + monthlyInterestRate, numberOfPayments);
        }

        public double InterestQuotient(double monthlyInterestRate, double compoundedInterestRate, int numberOfPayments)
        {
            return (monthlyInterestRate * compoundedInterestRate) / ((Math.Pow((1 + monthlyInterestRate), numberOfPayments)) - 1);
        }
    }
}
