using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
    internal class binarySearch
    {
        public void binarySearchAllowed(int[] array, int data)
        {
            int sortedCheckValue = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] >= array[i])
                {
                    sortedCheckValue++;
                }
            }
            if (sortedCheckValue == array.Length - 1)
            {
                Console.WriteLine("Array sorted - binary search is able to occur.");
                Console.Clear();
                Thread.Sleep(2000);
                BinarySearch(array, data);
            }
            else
            {
                Console.WriteLine("Array unsorted - binary search is unable to occur. Switching to linear search...");
                Thread.Sleep(2000);
                Console.Clear();
                linearSearch linearSearchInstance = new linearSearch();
                linearSearchInstance.LinearSearch(array, data);
            }
        }
        public void BinarySearch(int[] array, int data)
        {
            int start = 0;
            int end = array.Length - 1;
            int middle = (end + start) / 2;

            bool found = false;

            while (found == false && start <= end)
            {
                middle = (end + start) / 2;
                if (data > array[middle])
                {
                    start = middle + 1;

                }
                else if (data < array[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    Console.WriteLine("Item " + data + " found at index " + middle);
                    found = true;
                    Program.reset(array);
                }
            }
        }
    }
}
