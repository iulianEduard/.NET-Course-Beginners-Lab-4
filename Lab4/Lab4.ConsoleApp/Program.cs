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
            // test
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

            for(int i = 0; i < 10; i++)
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

    }
    
}
