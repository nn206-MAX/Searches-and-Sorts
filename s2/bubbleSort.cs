using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
    internal class bubbleSort
    {
        public void BubbleSort(int[] array)
        {
            int temp;
            int swaps = 0;
            int passes = 0;

            for (int i = 0; i < array.Length; i++)
            {
                swaps = 0;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swaps++;
                    }
                }

                if (swaps > 0) //Any swaps made?
                {
                    passes++; //A pass has been completed
                }

            }

            //Clears the viewing window for the next action
            Console.Clear();

            //Prints the sort results
            foreach (int i in array)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Thread.Sleep(2000);
            if (passes == 1)
            {
                Console.WriteLine("Completed in " + passes + " pass");
            }
            else
            {
                Console.WriteLine("Completed in " + passes + " passes");
            }
            Thread.Sleep(6000);

            //Clears the viewing window for the next action
            Console.Clear(); 
            Program.reset(array);
        }
    }
}
