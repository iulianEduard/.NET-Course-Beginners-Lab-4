using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (IsOdd(i))
            {
                Console.WriteLine(i);

            }
        }
        Console.ReadKey();
    }

    public static bool IsOdd(int value)
    {
        return value % 2 != 0;
    }
}