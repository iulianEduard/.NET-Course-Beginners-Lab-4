using System;

namespace Lab4.ConsoleApp.ClassType
{
    public class CarWithConstructors
    {
        public string name;
        public int currSpeed;

        public CarWithConstructors()
        {
            name = "Default";
            currSpeed = 5;
        }

        public CarWithConstructors(string carName)
        {
            name = carName;
        }

        public CarWithConstructors(string carName, int initialSpeed)
        {
            name = carName;
            currSpeed = initialSpeed;
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }

        public void PrintState()
        {
            Console.WriteLine("Car name: {0}, going {1} KPH", name, currSpeed);
        }
    }
}
