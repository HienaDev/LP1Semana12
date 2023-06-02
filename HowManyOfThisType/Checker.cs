using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    public static class Checker
    {
        

        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int temp = 0;

            foreach (object x in items)
            {
                if (x is T) temp++;
            }

            return temp;
        }

    }
}