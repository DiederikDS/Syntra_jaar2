using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Oefening.Classes
{
    internal class MyQueue<T>
    {

        public MyQueue()
        {
            items = new T[0];
        }

        private T[] items;

        public void Add(T item)
        {
            var newArray = new T[items.Length + 1];
            items.CopyTo(newArray, 0);
            newArray[items.Length] = item;
            items = newArray;
        }

        public T Remove()
        {
            var result = Peek();

            if (items.Length == 0)
            {
                return default;
            }

            var newArray = new T[items.Length - 1];
            for (int i = 1; i <= newArray.Length; i++)
            {
                newArray[i - 1] = items[i];
            }
            items = newArray;
            return result;
        }

        public T Peek()
        {
            if (items.Length > 0)
            {
                return items[0];
            }
            else
            {
                return default;
            }
            
        }

    }
}
