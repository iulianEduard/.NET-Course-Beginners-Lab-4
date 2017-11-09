using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp
{
    class Dreptunghi
    {
        double lungime;
        double latime;
    public void DreptunghiProg()
        {
            Console.WriteLine("Lungime: ");
            lungime = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Latime: ");
            latime = Convert.ToDouble(Console.ReadLine());
        }
    public double GetArea()
        {
            return lungime * latime;
        }
    public void Afisare()
        {
            Console.WriteLine("Lungime: {0}", lungime);
            Console.WriteLine("Latime: {0}", latime);
            Console.WriteLine("Suprafata: {0}", GetArea());
        }
    }
    class Algorithms
    {
        public void EvenOddNumbers()
        {
            List<int> t = Enumerable.Range(1, 100).ToList();

            var oddNumbers = t.Where(num => num % 2 != 0);
            var evenNumbers = t.Where(num => num % 2 == 0);
                Console.WriteLine("\nNumerele impare: ");

            foreach (int i in oddNumbers)
                Console.WriteLine(i);
                Console.WriteLine("\nNumerele pare: ");

            foreach (int i in evenNumbers)
                Console.WriteLine(i);
        }
        public void PrimeNumbers()
        {
            Console.WriteLine("\nNumerele prime: ");
            for (int x = 2; x < 100; x++)
            {
                int isPrime = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        isPrime++;

                    if (isPrime == 2) break;
                }
                if (isPrime != 2)
                    Console.WriteLine(x);
                isPrime = 0;
            }
        }
    }
}
