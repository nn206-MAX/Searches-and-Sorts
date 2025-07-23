using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
    internal class insertionSort
    {
        public void InsertionSort(int[] array)
        {
            int temp;
            int currentIndex;
            int currentValue;

            for (int i = 1; i < array.Length; i++)
            {
                currentIndex = i;
                currentValue = array[currentIndex];
                if ((array[currentIndex - 1] == array[currentIndex] || array[currentIndex - 1] < array[currentIndex]) && currentIndex < array.Length - 1)
                {                   
                    currentIndex = currentIndex + 1;
                    currentValue = array[currentIndex];
                }
                else
                {
                    while (array[currentIndex - 1] > array[currentIndex] && (currentIndex - 1) >= 0) //the value below is greater than the current value
                    {
                        temp = array[currentIndex - 1];
                        array[currentIndex - 1] = array[currentIndex];
                        array[currentIndex] = temp;
                        currentIndex--;

                        if (currentIndex - 1 < 0)
                        {
                            break;
                        }
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Thread.Sleep(6000);

            Console.Clear();
            Program.reset(array);
        }
    }
}
