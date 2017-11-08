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
            //StaticMethods2Work();
            // Class1 class1 = new Class1();
            //Console.WriteLine(class1.Add(null, 18));

            // SimpleCarWork();
            // SimpleCarWorkDifferent();

            /* int? n1 = null;
             int? n2 = 125;
             int? n3;
             n3 = n1 ?? n2;
             Console.WriteLine(n3);
             Class1 class1 = new Class1();
             Console.WriteLine( class1.Add(2, null));
             */

            // Start Tema
            // Dreptunghi
            /*Dreptunghi dreptunghi = new Dreptunghi();
            dreptunghi.DisplayDim();
            dreptunghi.OtherDimensions(4, 2);
            dreptunghi.DisplayDim();

            Dreptunghi dreptunghi1 = new Dreptunghi(200, 50);
            dreptunghi1.DisplayDim();
            dreptunghi1.OtherDimensions(0, 10);
            dreptunghi1.DisplayDim();
            */

            Algoritmica A = new Algoritmica();
            // A.NrPare();
            //A.NrImpare();
            // A.VerifNrPrim(11);
            //A.NrPrim();
            //  A.Compare(19,91,90);
            /* A.Triunghi(12, 90, 60);
             A.Triunghi(90, 90, 0);
             A.Triunghi(60, 60, 60);
             A.Triunghi(75, 75, 75);
             A.Triunghi(75, 65, 40);
            */
            // A.Ordonare(2,51,4,3,7,6,71,9);
            //A.NrCifre(123456789);
            //A.Palindrom();

            //End Tema

            //NullableOperations();

            // ClassWithConstructors();
            CCC();

            Console.ReadKey();
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
         //   myCar.name = "Freddy";
            myCar.PrintState();
        }

        static void ClassWithConstructors()
        {
            CarWithThis carWithThis = new CarWithThis();
            carWithThis.SetCarName("pisic");
            carWithThis.PrintState();

            CarWithChainedConstructors carWithChainedConstructors= new CarWithChainedConstructors(55);
            carWithChainedConstructors.PrintState();

            CarWithConstructors carWithConstructors1 = new CarWithConstructors();
            carWithConstructors1.SpeedUp(5);
            carWithConstructors1.PrintState();
            
            CarWithConstructors carWithConstructors2 = new CarWithConstructors("seat");
            carWithConstructors2.SpeedUp(1);
            carWithConstructors2.PrintState();
            
            CarWithConstructors carWithConstructors3 = new CarWithConstructors("volvo", 90);
            carWithConstructors3.SpeedUp(7);
            carWithConstructors3.PrintState();
            
            Console.ReadKey();
        }

        static void CCC()
        {
           // CarWithChainedConstructors carWithChainedConstructors = new CarWithChainedConstructors(100);
           // carWithChainedConstructors.SpeedUp(60);
           // carWithChainedConstructors.PrintState();
           
            //CarWithChainedConstructors carWithChainedConstructors1 = new CarWithChainedConstructors("Cow and Chicken");
            //carWithChainedConstructors1.SpeedUp(7);
            // carWithChainedConstructors1.PrintState();

            CarWithChainedConstructors withChainedConstructors = new CarWithChainedConstructors();
            withChainedConstructors.PrintState();
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
