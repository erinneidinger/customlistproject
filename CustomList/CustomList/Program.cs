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

            CustomList<int> listone = new CustomList<int>();
            listone.Add(1);
            listone.Add(2);
            listone.Add(3);
            CustomList<int> listtwo = new CustomList<int>();
            listtwo.Add(3);
            listtwo.Add(4);
            listtwo.Add(5);

            customlist = listone - listtwo;
        }
    }
}

