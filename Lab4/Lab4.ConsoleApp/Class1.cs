using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.ConsoleApp
{
    class Class1
    {
        public int Add(int? x, int? y)
        {
            int? sum=0;
            if (x.HasValue)
                sum += x.Value;
            if (y.HasValue)
                sum += y.Value;
            return sum.Value;
            
        }
    }
}
