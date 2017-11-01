using System;

namespace Lab4.ConsoleApp.ClassType
{
    public class Car
    {
        public string name;
        public int currSpeed;

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} KPH", name, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
