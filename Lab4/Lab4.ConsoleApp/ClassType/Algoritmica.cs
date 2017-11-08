using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp.ClassType
{
    class Algoritmica
    {
        
        public void NrPare()
        {
            for (int i = 0; i <= 100; i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
            }
        }


        public void NrImpare()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }

        public int VerifNrPrim(int n)
        {

            int x = 0;

            if (n == 0 || n == 1)
            {
                Console.Write(n);
                Console.WriteLine(" Numarul trebuie sa fie diferit de 0 si 1");
            }
            else
            {
                for (int i = 2; i < n ; i++)
                {
                    if (n % i == 0)
                    {
                        x++;
                    }

                }
                if (x == 0)
                {

                    //Console.WriteLine("Numar prim");
                    return 1;
                }
                else
                {

                    // Console.WriteLine("Numarul nu e prim");
                    return 0;
                }

            }
            return 2;
            
        }

        public void NrPrim()
        {
           // int[] nr = new int [100];
            {
               for(int i=0;i<=100;i++)
                {
                    if (VerifNrPrim(i) == 1)
                    {
                        Console.WriteLine(i);
                    }

                }
               
            }
        }
        
        public void Compare(int a, int b, int c)
        {
            int Max=a;
            int Min=a;  
            if (b < Min)
                Min = b;
            if (b > Max)
                Max = b;
            if (c < Min)
                Min = c;
            if (c > Max)
                Max = c;

            Console.WriteLine("Max = {0}, Min = {1}", Max,Min);
        }

        public void Triunghi(int a, int b, int c)
        {
            Console.WriteLine("Valorile introduse sunt : {0}, {1}, {2}", a, b, c);

            if (a!=0 && b!=0 && c!=0 && (a + b + c == 180))
                Console.WriteLine("Numerele introduse reprezinta unghiurile unui triunghi");
            else
            Console.WriteLine("Nu ai fost atent in clasa a 5-a");
        }

      
        public void Ordonare(params int [] nr)
        {
            int a = 0;
            int schimbator = 0;

             Console.WriteLine("Numerele introduse:");
            for (int i = 0; i < nr.Length; i++)
            {
                Console.Write(nr[i] + " ");
            }
            Console.WriteLine();
            
       
            do
            {
                a = 0;
                for (int i = 0; i < nr.Length - 1 ; i++)
                    if (nr[i] > nr[i + 1])
                    {
                        schimbator = nr[i];
                        nr[i] = nr[i + 1];
                        nr[i + 1] = schimbator;
                        a = 1;
                    }
            }
            while (a == 1);
            for (int i = 0; i < nr.Length; i++)
            {
                Console.Write(nr[i] + " ");
            }
            Console.WriteLine();
            do
            {
                a = 0;
                for (int i = 0; i < nr.Length - 1; i++)
                    if (nr[i] < nr[i + 1])
                    {
                        schimbator = nr[i];
                        nr[i] = nr[i + 1];
                        nr[i + 1] = schimbator;
                        a = 1;
                    }
            }
            while (a == 1);
            for (int i = 0; i < nr.Length; i++)
            {
                Console.Write(nr[i] + " ");
            }

        }

    


        public void NrCifre(int n)
        {
            int sum = 0;
            string nr;
            nr = n.ToString();
            Console.WriteLine("Numarul de cifre este {0}",nr.Length);

            while (n!= 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            
            Console.WriteLine("Suma cifrelor este {0}", sum);
            
        }


        public void Palindrom()
        {
          
            for (int i = 100 ; i < 1000; i++)
            {
                if (i % 10 == i / 10 / 10 % 10)
                    Console.WriteLine(i);
            }
            
            
        }
    }
}
