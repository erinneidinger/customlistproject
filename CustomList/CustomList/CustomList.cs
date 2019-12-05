using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList <T>
    {
        T[] items;

        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if(value <= 5)
                {
                    capacity = value;
                }
                else if (value > 5)
                {
                    capacity = 8;
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
        }
        public void Add(T item)
        {

        }
    }
}
