﻿using System;
using System.Collections.Generic;
using System.Text;

namespace codeforevenorodd
{
    class Program
    {


        static void Main(string[] args)
        {
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
            Console.ReadKey();
        }

    }
}