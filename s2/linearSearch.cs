using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
    internal class linearSearch
    {
        public void LinearSearch(int[] array, int data)
        {
            int i = 0;
            while (array[i] != data)
            {
                i++;
                if (array[i] == data)
                {
                    Console.WriteLine("Item " + data + " found at index " + i);
                    Console.Clear();
                    Program.reset(array);
                }
                else
                {
                    if (i == array.Length)
                    {
                        Console.WriteLine("Item " + data + " not found.");
                        Console.Clear();
                        Program.reset(array);
                    }
                }
            }
        }
    }
}
