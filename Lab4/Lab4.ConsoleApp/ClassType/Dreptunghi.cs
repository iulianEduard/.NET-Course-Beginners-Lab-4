using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp.ClassType
{
    class Dreptunghi
    {
        public int lungime;
        public int latime;

        public Dreptunghi()
        {
            lungime = 10;
            latime = 5;
        }

        public Dreptunghi(int L, int l)
        {
            lungime = L;
            latime = l;
        }

        public void OtherDimensions(int a,int b)
        {
            lungime = 2 * a + 2 * b;
            latime += 5;
        }

        public void DisplayDim()
        {
            Console.WriteLine("Lungimea = {0}", lungime);
            Console.WriteLine("Latimea = {0}",latime);
        }
    }
}
