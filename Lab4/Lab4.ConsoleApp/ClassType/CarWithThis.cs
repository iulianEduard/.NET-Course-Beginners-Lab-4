using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp.ClassType
{
    public class CarWithThis
    {
        public string name;
        public int currSpeed;

        public CarWithThis()
        {
            name = "Default";
            currSpeed = 0;
        }

        public void SetCarName(string name)
        {
            this.name = name;
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
