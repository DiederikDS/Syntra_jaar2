using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningStack.Classes
{
    internal class MyStack<T>
    {
        private T[] Items;

        public MyStack()
        {
            Items = new T[0];
        }

        public void Add(T item)
        {
            T[] newArray = new T[Items.Length + 1];
            Items.CopyTo( newArray, 0 );
            newArray[Items.Length] = item;
            Items = newArray;
        }

        public T Peek()
        {
            if (Items.Length == 0)
            {
                return default;
            }
            return Items[Items.Length - 1];
        }

        public T Remove()
        {
            var result = Peek();
            T[] newArray = new T[Items.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Items[i];
            }
            Items = newArray;
            return result;
        }

    }
}
