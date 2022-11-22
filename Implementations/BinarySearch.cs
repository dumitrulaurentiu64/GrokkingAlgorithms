using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Implementations
{
    internal class BinarySearch
    {
        public static void TryBinarySearch()
        {
            // int array
            int[] list = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int target = 7;

            // string array
            //string[] list = { "asdf", "bsdf", "csdf", "dsdf", "esdf", "fsdf", "gsdf", "hsdf" };
            //string target = "bsdf";

            int result = Binary_Search<int>(list, target);

            if (result >= 0)
            {
                Console.WriteLine($"The index of the target element is : {result+1}.");
            } else
            {
                Console.WriteLine("Target element was not found in the array!");
            }
        }

        private static int Binary_Search<T>(T[] list, T target) where T : IComparable
        {
            int low = 0;
            int high = list.Length-1;

            while (low <= high) {
                int mid = (low+high)/2;
                T guess = list[mid];

                int result = guess.CompareTo(target);

                if ( result == 0 )
                {
                    return mid;
                } else if ( result > 0 ) {
                    high = mid - 1;
                } else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
