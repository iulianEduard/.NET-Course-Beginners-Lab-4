using Lab4.ConsoleApp.ClassType;
using Lab4.ConsoleApp.NullableTypes;
using Lab4.ConsoleApp.StaticType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticMethods2Work();
        }

        #region Working with Nullable

        static void NullableOperations()
        {
            Console.WriteLine("***** Fun with Nullable Data* ****\n");
            DatabaseReader dr = new DatabaseReader();

            int? i = dr.GetIntFromDatabase();

            if (i.HasValue)
            {
                Console.WriteLine("Value of ’i’ is: {0}", i.Value);
            }
            else
            {
                Console.WriteLine("Value of ’i’ is undefined.");
            }

            // Get bool from "database".
            bool? b = dr.GetBoolFromDatabase();

            if (b != null)
            {
                Console.WriteLine("Value of ’b’ is: {0}", b.Value);
            }
            else
            {
                Console.WriteLine("Value of ’b’ is undefined.");
            }

            Console.ReadLine();
        }

        static void TreatingNullValues()
        {
            Console.WriteLine("***** Fun with Nullable Data* ****\n");

            DatabaseReader dr = new DatabaseReader();

            int _myData = 0;
            if (dr.GetIntFromDatabase().HasValue)
            {
                _myData = dr.GetIntFromDatabase().Value;
            }
            else
            {
                _myData = 100;
            }
            int myData = dr.GetIntFromDatabase() ?? 100;

            Console.WriteLine("Value of myData: {0}", myData);
            Console.ReadLine();
        }

        #endregion Working with Nullable

        #region Working with Classes

        static void SimpleCarWork()
        {
            Car myCar = new Car();

            myCar.name = "Audi";
            myCar.currSpeed = 10;

            for (int i = 0; i < 10; i++)
            {
                myCar.SpeedUp(i * 10);
                myCar.PrintState();
            }
        }

        static void SimpleCarWorkDifferent()
        {
            Car myCar;
            myCar = new Car();
            myCar.name = "Freddy";
        }

        static void ClassWithConstructors()
        {
            CarWithConstructors carWithConstructors1 = new CarWithConstructors();
            carWithConstructors1.SpeedUp(5);
            carWithConstructors1.PrintState();

            CarWithConstructors carWithConstructors2 = new CarWithConstructors("seat");
            carWithConstructors1.SpeedUp(1);
            carWithConstructors1.PrintState();

            CarWithConstructors carWithConstructors3 = new CarWithConstructors("volvo", 90);
            carWithConstructors1.SpeedUp(7);
            carWithConstructors1.PrintState();

            Console.ReadKey();
        }

        #endregion Working with Classes

        #region Working with Static

        static void StaticSimpleWork()
        {
            SavingsAccount savingsAccount1 = new SavingsAccount(50);
            SavingsAccount savingsAccount2 = new SavingsAccount(100.25);
            SavingsAccount savingsAccount3 = new SavingsAccount(150.75);

            Console.ReadKey();
        }

        static void StaticMethodsWork()
        {
            SavingsAccount savingsAccount1 = new SavingsAccount(50);
            SavingsAccount savingsAccount2 = new SavingsAccount(100.25);

            Console.WriteLine("Interest rate is : {0}", SavingsAccount.GetInterestRate());

            SavingsAccount savingsAccount3 = new SavingsAccount(150.75);
            Console.WriteLine("Interest rate is : {0}", SavingsAccount.GetInterestRate());

            Console.ReadKey();
        }

        static void StaticMethods2Work()
        {
            SavingsAccount savingsAccount1 = new SavingsAccount(50);
            SavingsAccount savingsAccount2 = new SavingsAccount(100.25);

            Console.WriteLine("Interest rate is : {0}", SavingsAccount.GetInterestRate());
            SavingsAccount.SetInteresetRate(0.08);
            Console.WriteLine("Interest rate is : {0}", SavingsAccount.GetInterestRate());

            SavingsAccount savingsAccount3 = new SavingsAccount(100.25);
            Console.WriteLine("Interest rate is : {0}", SavingsAccount.GetInterestRate());

            Console.ReadKey();
        }

        #endregion Working with Static


        static void PrimeNumbers()
        {
            bool prin = true;
            Console.WriteLine("Numerele Prime de la 1 la 100");
            for (int k = 2; k <= 100; k++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (k != j && k % j == 0)
                    {
                        prin = false;
                        break;
                    }
                }
                if (prin)
                {
                    Console.WriteLine("\t" + k);
                }
                prin = true;
            }
            Console.ReadKey();

        }
        static void OddNumbers()
        {
            //int i=0;
            for (int i = 0; i <= 100; i++)
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            Console.ReadLine();
        }
        static void EvenNumbers()
        {
            int i;
            for (i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
        static void BiggestNumber()
        {
            Console.WriteLine("Please enter 3 numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The biggest number is: " + b);
            }
            else
            {
                Console.WriteLine("The biggest number is: " + c);
            }
        }
        static void DescendingNumbers()
        {
            int val, isDecrement;
            Console.WriteLine("Please enter a number!");
            val = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter 1 to go Descending order!");
            isDecrement = Int32.Parse(Console.ReadLine());

            if (isDecrement == 1)
            {
                for (int i = val; i >= (val - 10); i--)
                    Console.WriteLine(i);
            }
            else
            {
                for (int i = val; i <= (val + 10); i++)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void CountingDigitsAndSum()
        {
           
            Console.Write("\n\n Recursion : Count the number of digits in a number :\n");
            Console.Write("---------------------------------------------------------\n");
            Console.Write(" Input any number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n The number {0} contains number of digits : {1} ", num, getDigits(num, 0));
            Console.ReadLine();
        }

        public static int getDigits(int n1, int nodigits)
        {
            if (n1 == 0)
                return nodigits;

            return getDigits(n1 / 10, ++nodigits);
        }
        static void PalindromeNumbers()
        {
            for (int k = 1; k <= 100; k++)
            {

                string data = k.ToString();               //converts the int value of k into sting

                bool isPalindrome = true;

                for (int i = 0; i < data.Length / 2; i++)
                {

                    if (data[i] != data[(data.Length - 1) - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    Console.WriteLine("Palindrome :" + k);
                }
            }


            Console.ReadKey();
        }
    }
}

