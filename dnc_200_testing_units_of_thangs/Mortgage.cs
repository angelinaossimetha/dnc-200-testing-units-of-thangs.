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

			double monthlyInterestRate = (interest / 100) / period;
			int numberOfPayments = term * period;
			double compoundedInterestRate = Math.Pow((1 + monthlyInterestRate), numberOfPayments);
			double interestQuotient = (monthlyInterestRate * compoundedInterestRate) / ((Math.Pow((1 + monthlyInterestRate), numberOfPayments)) - 1);
			double monthlyPayment = principal * interestQuotient;
			return Math.Round(monthlyPayment,2);

		}
	}
}
