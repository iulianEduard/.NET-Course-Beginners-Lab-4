using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 100; i=i+2)
        {
            if (IsEven(i))
            {
                Console.WriteLine(i);
                
            }
        }
        Console.ReadKey();
    }

    public static bool IsEven(int value)
    {
        return value % 2 == 0;
    }
}