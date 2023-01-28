using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Implementations
{
    internal class SelectionSort
    {
        public static void TrySelectionSort()
        {
            // int array
            int[] list = { 23, 12, 754, 283, 152, 55, 8, 952, 759, 534, 692, 44 };

            int[] orderedList = Selection_Sort(list);

            Console.WriteLine("Unordered list:");
            list.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Console.WriteLine("Ordered list:");
            orderedList.ToList().ForEach(i => Console.WriteLine(i.ToString()));

        }

        private static int[] Selection_Sort(int[] list)
        {
            int[] newList = new int[list.Length];
            int smallestIndex;
            int listLenght = list.Length;

            for (int i = 0; i < listLenght; i++)
            {
                // find index of smallest number
                smallestIndex = FindSmallest(list);

                // add smallest number found to new array
                newList[i] = list[smallestIndex];

                // remove smallest number from old list
                list = list.Where(val => val != list[smallestIndex]).ToArray();
            }
            return newList;
        }

        private static int FindSmallest(int[] list)
        {
            int smallestIndex = 0;
            int smallest = list[0];
            
            for(int i = 1; i < list.Length; i++)
            {
                if (smallest > list[i])
                {
                    smallest = list[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
    }
}
