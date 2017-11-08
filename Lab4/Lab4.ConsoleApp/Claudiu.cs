using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp
{
    class Claudiu
    {
        // Tema Lab2

        static void Main(string[] args)
        {

            int num1 = 2;
            int num2 = 4;



            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);

            int a = 2;
            int b = 1;
            int c = 2;
            int d = 3;

            d = c + b - a;
            Console.WriteLine(d);
            Console.ReadLine();


        }
        // Tema Lab3
        public enum MyEnum
        {
            Clujul=0,
            devine,
            tot,
            mai,
            plin,
            de,
            masini,
            facand,
            circulatia,
            anevoioasa,
            pe,
            zi,
            ce,
            trece,
                   
        }

        public void DiaplayEnum(MyEnum myEnum)
        {
            switch (myEnum)
            {
                case MyEnum.Clujul:
                    Console.WriteLine("Clujul");
                    break;
                case MyEnum.devine:
                    Console.WriteLine("devine");
                    break;
                case MyEnum.tot:
                    Console.WriteLine("tot");
                    break;
                case MyEnum.mai:
                    Console.WriteLine("mai");
                    break;
                case MyEnum.plin:
                    Console.WriteLine("plin");
                    break;
                case MyEnum.de:
                    Console.WriteLine("de");
                    break;
                case MyEnum.masini:
                    Console.WriteLine("masini");
                    break;
                case MyEnum.facand:
                    Console.WriteLine("facand");
                    break;
                case MyEnum.circulatia:
                    Console.WriteLine("circulatia");
                    break;
                case MyEnum.anevoioasa:
                    Console.WriteLine("anevoioasa");
                    break;
                case MyEnum.pe:
                    Console.WriteLine("pe");
                    break;
                case MyEnum.zi:
                    Console.WriteLine("zi");
                    break;
                case MyEnum.ce:
                    Console.WriteLine("ce");
                    break;
                case MyEnum.trece:
                    Console.WriteLine("trece");
                    break;

            }
        }

                
            // o alta varianta...
            string[] stringArray = { "Clujul devine tot mai plin de masini facand circulatia anevoioasa pe zi ce trece" };

            foreach(string item in stringArray)
            
            Console.WriteLine("{0}",stringArray);
            
    }

    // tema Lab4
    // numere Impare
        public void ()
        {
                for (int i = 0; i <= 100; i++)
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            Console.ReadLine();
        }

    // numere Pare
        public void ()
        {
                for (int i = 2; i <= 100; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            Console.ReadLine();
        }
    // numere prime 0-100
    static void ()
    {
    Console.WriteLine("numere prime de la 0 la 100!");
        Console.WriteLine(2);
        for(int i=3;i<=100;i++)
        {
            bool isPrime = true;
            for(int j=2;j<=Math.Sqrt(i);j++)
            {
                if(i%j==0)
                {
                    isPrime=false;
                    break;
                }
            }
            if(isPrime)
            {
                Console.WriteLine(i);
            }
        }
     // numere palindrom

    static void
    for (int k = 1; k <= 100; k++)
            {
 
                string data = k.ToString();               //converts the int value of k into sting

bool isPalindrome = true;
 
                for (int i = 0; i<data.Length / 2; i++)
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
