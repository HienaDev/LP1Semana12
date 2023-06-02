using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T t1, t2, t3;


        public Guarda3()
        {
            t1 = default;
            t2 = default;
            t3 = default;
        }

        public T GetItem(int i)
        {
            if (i < 0 || i > 2) throw new IndexOutOfRangeException();

            if(i == 0)
                return (t1);
            else if(i == 1)
                return (t2);
            else if(i == 2)
                return (t3);
            else
                return (default);
        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2) throw new IndexOutOfRangeException();

            if(i == 0)
                t1 = item;
            else if(i == 1)
                t2 = item;
            else if(i == 2)
                t3 = item;

            //list[i] = item;
        }

    }
}