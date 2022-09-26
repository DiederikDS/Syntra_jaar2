using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningSpecialList.Classes
{
    internal class SpecialList<T> where T : IComparable
    {
        private T[] Items;

        public SpecialList()
        {
            Items = new T[0];
        }

        public void Add(T item)
        {
            T[] newArray = new T[Items.Length + 1];
            Items.CopyTo( newArray, 0);
            newArray[Items.Length] = item;
            Items = newArray;
        }

        public T GetItemByIndex(int i)
        {
            if (Items.Length == 0)
            {
                return default;
            }

            return Items[i];
        }

        public int GetCount()
        {
            return Items.Length;
        }

        public void RemoveItem(T item)
        {
            if (Items.Contains(item))
            {
                T[] newArray = new T[Items.Length-1];

                int counter = 0;

                for (int i = 0; i < Items.Length; i++)
                {
                    if (!item.Equals(Items[i]))
                    {
                        newArray[counter] = Items[i];
                        counter++;
                    }
                }
                Items = newArray;

            }
            else
            {
                Console.WriteLine($"{item} not found!");
            }
        }
    }
}
