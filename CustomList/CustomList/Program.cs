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
            customlist.Add(1);
            customlist.Add(2);
            customlist.ToString();

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
