using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customlist = new CustomList<int>();
            customlist.Add(2);
            customlist.Add(4);
            customlist.Add(6);
            customlist.Add(8);
            customlist.Add(10);

            //int[] one = new int[4];
            //one[0] = 2;
            //one[1] = 4;
            //one[2] = 6;
            //one[3] = 8;

            //int[] two = new int[8];
            //two[4] = 10;

        }
    }
}
