using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace JustLikeACollection   
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T t1, t2, t3;


        public Guarda3()
        {
            t1 = default;
            t2 = default;
            t3 = default;
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return t1;
            yield return t2;
            yield return t3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {

            if (EqualityComparer<T>.Default.Equals(t1, default(T)))
            {
                t1 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(t2, default(T)))
            {
                t2 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(t3, default(T)))
            {
                t3 = item;
            }
            /* else
            {
                t1 = item;
            } */
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