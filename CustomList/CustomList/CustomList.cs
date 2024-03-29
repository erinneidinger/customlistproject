﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
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
            bool didRemove = false;
            T[] tempitems = new T [capacity];
            for(int i = 0, j = 0; i < count; i++, j++)
            {
                if (items[i].Equals(item) && !didRemove)
                {
                    j--;
                    didRemove = true;
                    DecreasingCount();
                }
                else if(items[i].Equals(item) && didRemove)
                {
                    tempitems[j] = items[i];
                    didRemove = true;
                }
                else
                {
                    tempitems[j] = items[i];
                }
            }
            items = tempitems;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += items[i].ToString();
            }
            return result;
        }

        public static CustomList<T> operator +(CustomList<T> listone, CustomList<T> listtwo) //add lists one and two
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < listone.count; i++)
            {
                result.Add(listone[i]);
            }
            for (int j = 0; j < listtwo.count; j++)
            {
                result.Add(listtwo[j]);
            }
            
            return result;
        }

        public static CustomList<T> operator -(CustomList<T> listone, CustomList<T> listtwo) //compare lists one and two
        {
            CustomList<T> result = new CustomList<T>(); //creating a new list for the sum

            for (int i = 0; i < listone.count; i++)  //each character in listone will be tested for a match with listtwo.
            {
                bool NotEqual = true;
                for (int j = 0; j < listtwo.count; j++) 
                {
                    if (listone[i].Equals(listtwo[j])) //if a match is found, the character will be subtracted or removed from the list. 
                    {
                        NotEqual = false;
                    }
                }
                if (NotEqual == true) //if no match is found, the character will be added to the results list. 
                {
                    result.Add(listone[i]);
                }
            }
            return result; //returns the sum 
        }
         
        public CustomList<T> Zip (CustomList<T> listone, CustomList<T> listtwo)
        {
            CustomList<T> result = new CustomList<T>();

            if(listone.count >= listtwo.count)
            {
                for (int i = 0; i < listone.count; i++)
                {
                    if (i < listone.count)
                    {
                        result.Add(listone[i]);

                        if (i < listtwo.count)
                        {
                            result.Add(listtwo[i]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < listtwo.count; i++)
                {
                    if (i < listtwo.count)
                    {
                        result.Add(listtwo[i]);

                        if (i < listone.count)
                        {
                            result.Add(listone[i]);
                        }
                    }
                }
            }
            return result;
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
