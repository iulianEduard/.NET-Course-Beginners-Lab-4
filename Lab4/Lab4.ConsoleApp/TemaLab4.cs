using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp
{
    class TemaLab4
    {
        public static void NumereParImpare()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (EstePar(i))
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; i >= 100; i++)
            {
                if (EsteImpar(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        public static bool EsteImpar(int value)
        {
            return value % 2 != 0;
        }
        public static bool EstePar(int value)
        {
            return value % 2 == 0;
        }

        public static void NumerePrime()
        {
            int prime = 0;
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i % j == 0)
                        prime++;
                }
                if (prime == 1)
                {
                    Console.WriteLine(i);
                }
                prime = 0;
            }
            Console.ReadLine();

        }
        public static void ComparareaNumerelor()
        {
            int[] array = new int[3];
            int maxint = array[0];
            int minint = array[0];
            foreach(int value in array)
            {
                if(value < maxint) maxint = value;
                if (value > minint) minint = value;
            }
        }
        public static void  DeterminareaUnghiului()
        {

        }

        public static void SumaNumerelor()
        {
            Console.WriteLine("Introduceti un numar: ");
            int n = 0;
            n = Math.Abs(n);
            int sum = 0;
            while (n != 0)
            {
                sum += 10;
                n /= 10;
            }
        }

        public static void CrescatorDescrescator()
        {
            int[] myInt = new int[10];
            Console.WriteLine("Introdu zece numere: ");
            Array.Sort(myInt);

            foreach (var n in myInt)
            {
                Console.WriteLine(n);
            }
            Array.Reverse(myInt);
            foreach (var n in myInt)
            {
                Console.WriteLine(n.ToString());
            }

        }

        //Un palindrom este un șir de caractere (de obicei cuvinte, fraze sau numere) 
        //care citit de la stânga la dreapta sau de la dreapta la stânga rămâne neschimbat.
        public static void Palindorm()
        {
            int sum = 0;

            for(int i = 0; i <= 1000; i++)
            {
                for(int b = 0; b<= 1000; b++)
                {
                    b = i % 10;
                    sum = sum * 10 + b;
                }
                if(i == sum)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
