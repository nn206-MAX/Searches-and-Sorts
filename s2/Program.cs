using Microsoft.VisualBasic.FileIO;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace s2
{
    internal class Program
    {
        public static void invalid(int[] array) //invalid option input
        {
            Console.WriteLine("Invalid option.");
            Thread.Sleep(4521);
            Console.Clear();
            Option(array);
        }
        public static void reset(int[] array)
        {
            int option;

            Console.WriteLine("Enter 1 to use the same array, or 2 to create a new one: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1) 
            {
                Console.Clear();
                Option(array);
            }
            else if (option == 2)
            {
                Console.Clear();
                arraySet();
            }
            else
            {
                invalid(array);
            }

        }
        public static void arraySet()
        {
            int arraySize = 0;

            Console.WriteLine("How many elements should be in the array? ");
            arraySize = int.Parse(Console.ReadLine());

            int[] array = new int[arraySize]; //new array created

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Enter item " + (i+1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Option(array);
        }

        public static void Option(int[] array)
        {
            Console.WriteLine("Search through or sort through the array? Enter 1 to search for a value or 2 to sort it: ");
            int mainoption = int.Parse(Console.ReadLine());

            if (mainoption == 1)
            {
                Console.WriteLine("Which data item are you looking for? ");
                int data = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter B for binary search or L for linear search: ");
                char searchOption = char.Parse(Console.ReadLine());

                if (searchOption == 'B' || searchOption == 'b')
                {
                    binarySearch binarySearchInstance = new binarySearch();
                    binarySearchInstance.binarySearchAllowed(array, data);
                }
                else if (searchOption == 'L' || searchOption == 'l')
                {
                    linearSearch linearSearchInstance = new linearSearch();
                    linearSearchInstance.LinearSearch(array, data);
                }
                else
                {
                    invalid(array);
                }
            }
            else if (mainoption == 2)
            {
                Console.WriteLine("Enter B for bubble sort, I for insertion sort, M for merge sort or Q for quick sort: ");
                char sortOption = char.Parse(Console.ReadLine());

                if (sortOption == 'B' || sortOption == 'b')
                {
                    bubbleSort bubbleSortInstance = new bubbleSort();
                    bubbleSortInstance.BubbleSort(array);
                    
                }
                else if (sortOption == 'I' || sortOption == 'i')
                {
                    insertionSort insertionSortInstance = new insertionSort();
                    insertionSortInstance.InsertionSort(array);
                }
                else if (sortOption == 'M' || sortOption == 'm')
                {
                    mergeSort mergeSortInstance = new mergeSort();
                    mergeSortInstance.MergeSort(array);
                }
                else if (sortOption == 'Q' || sortOption == 'q')
                {
                    quickSort quickSortInstance = new quickSort();
                    quickSortInstance.QuickSort(array);
                }
                else
                {
                    invalid(array);
                }
            }
            else
            {
                invalid(array);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ARRAY");
            Thread.Sleep(2000);

            Console.Clear();
            Thread.Sleep(2000);

            arraySet();
        }
    }
}