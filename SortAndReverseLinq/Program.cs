using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndReverseLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someInt = { 30, 12, 4, 3, 12 };

            IEnumerable<int> sortedInts = from i in someInt orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            //This is to descending
            IEnumerable<int> reversedSortedInts = from i in someInt orderby i descending select i;

            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }
        }
    }
}
