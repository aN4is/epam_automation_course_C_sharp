using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace at_academy.crafts
{
    public class Generics
    {
        public class GenericList<T>
        {
            public void Add(T value)
            {

            }

            public T this[int index]
            {
                get { throw new NotImplementedException(); }
            }
        }

        public class GenericDictionary<TKey, TValue>
        {
            public void Add(TKey key, TValue value)
            {

            }
        }
    }

}
