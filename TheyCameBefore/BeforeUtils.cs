using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> list, T variable) 
                                                    where T : struct, IComparable
                                                        
        {
            foreach (T item in list)
            {
                if (item.CompareTo(variable) == -1)
                {
                    yield return item;
                }
            }
        }

    }
}