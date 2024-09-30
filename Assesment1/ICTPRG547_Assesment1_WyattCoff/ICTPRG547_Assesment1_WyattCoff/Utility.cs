using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assessment1_WyattCoff
{
    public static class Utility
    {
        /// <summary>
        /// Performs a linear search on an array of any type <T>.
        /// Returns true if the target is found, false otherwise.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="array">The array to search through.</param>
        /// <param name="target">The target element to search for.</param>
        /// <returns>True if the target is found; otherwise, false.</returns>
        public static bool LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int i = 0;
            bool found = false;

            while (!found && i < array.Length)  // While not found and not at the end of the array
            {
                if (target.CompareTo(array[i]) == 0)  // If match found
                {
                    found = true;
                }
                else
                {
                    i++;  // Move to next element if no match
                }
            }

            return i < array.Length;  // Return true if target is found, otherwise false
        }

        /// <summary>
        /// Performs a binary search on a sorted array of any type <T>.
        /// Returns the index of the target if found, or -1 if the target is not found.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="array">The sorted array to search through.</param>
        /// <param name="target">The target element to search for.</param>
        /// <returns>The index of the target if found; otherwise, -1.</returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;

            do
            {
                mid = (min + max) / 2;

                if (array[mid].CompareTo(target) == 0)  // If target is found
                    return mid;

                if (target.CompareTo(array[mid]) > 0)  // Target is in the upper half
                    min = mid + 1;
                else  // Target is in the lower half
                    max = mid - 1;
            }
            while (min <= max);

            return -1;  // Return -1 if not found
        }

        /// <summary>
        /// Sorts an array of any type <T> in ascending order using the Bubble Sort algorithm.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="array">The array to sort.</param>
        public static void BubbleSortAscending<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        // Swap the elements
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts an array of any type <T> in descending order using the Bubble Sort algorithm.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="array">The array to sort.</param>
        public static void BubbleSortDescending<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) < 0)
                    {
                        // Swap the elements
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
    }
}


