using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp.StaticType
{
    public class SavingsAccount
    {
        public double currBalance;

        public static double currInterestRate;

        public SavingsAccount(double ballance)
        {
            currBalance = ballance;
            currInterestRate = 0.04;
        }

        static SavingsAccount()
        {
            Console.WriteLine("This is from static constructor");
        }

        public static void SetInteresetRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
