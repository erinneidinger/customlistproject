using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        public T[] items;
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (count > capacity)
                {
                    capacity = value;
                }
            }
        }

        public T this [int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                if (i <= Count)
                {
                    items[i] = value;
                }
            }
        }
        
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;
        }

        public void Add(T item)
        {
            if (count == capacity) 
            {
                SwappingCapacity();
            }
                items[count] = item; //AddingToIndex<T>();

            IncreasingCount();
        }

        public void Remove(T item)
        {
            T[] tempitems = new T [capacity];
            for(int i = 0, j = 0; i < count; i++, j++)
            {
                if (items[i].Equals(item))
                {
                    j--;
                }
                //else if (items[i].Equals(item) == false)
                //{

                //}
                else
                {
                    tempitems[j] = items[i];
                } 
            }
            items = tempitems;
            DecreasingCount();
        }

        public void SwappingCapacity()
        {
            T[] items2 = new T[capacity *= 2]; 

            for (int i = 0; i < count; i++)
            {
                items2[i] = items[i];
            }
            items = items2;
        }

        public void IncreasingCount() 
        {
            count++;
        }
        public void DecreasingCount()
        {
            count--;
        }
    }
}
