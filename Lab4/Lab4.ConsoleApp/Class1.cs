using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp
{
    class Class1
    {
        static int Add(int?x,int?y)
        {
            int suma = 0;
            if(x.HasValue)
            {
                suma += x.Value;
            }
            if (y.HasValue)
            {
                suma += y.Value;
            }
            return suma;
        }

    }
}
