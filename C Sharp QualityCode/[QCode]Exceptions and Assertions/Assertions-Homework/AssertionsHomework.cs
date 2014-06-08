namespace AssertionsHomework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Assertions Homework class
    /// </summary>
    public class AssertionsHomework
    {
        /// <summary>
        /// Where all the magic happens
        /// </summary>
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 3, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            int[] arr2 = new int[] { };
            SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // SelectionSort(new int[0]); // Test sorting empty array
            SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }

        /// <summary>
        /// Generic SelectionSort algorithm to sort arrays in ascending order
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="array">Array to be sorted</param>
        public static void SelectionSort<T>(T[] array) where T : IComparable<T>
        {
            Debug.Assert(array != null, "Null referenced array");
            Debug.Assert(array.Length > 0, "Invalid array lenght");

            for (int index = 0; index < array.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(array, index, array.Length - 1);
                Swap(ref array[index], ref array[minElementIndex]);
            }

            // additional check for correct sorting
            for (int index = 0; index < array.Length - 1; index++)
            {
                Debug.Assert(array[index].CompareTo(array[index + 1]) <= 0, "Array is not correctly sorted!");
            }
        }

        /// <summary>
        /// Public binary search method
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="arr">searched array</param>
        /// <param name="value">searched value</param>
        /// <returns>integer value</returns>
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null");
            Debug.Assert(value != null, "Searched value cannot be null!");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, "The array is not sorted!");
            }

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        /// <summary>
        /// Private method to search index of the smallest element in array
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="arr">searched array</param>
        /// <param name="startIndex">start from: index</param>
        /// <param name="endIndex">end: index</param>
        /// <returns>integer index</returns>
        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
           where T : IComparable<T>
        {
            /*
             * Because this method is private we are assured that array state is checked in SelectionSort method.
             * Here we can only check for correct startIndex and endIndex, although these variables are givven from
             * the for-loop in SelecetionSort method.
             */

            Debug.Assert(0 <= startIndex && startIndex <= endIndex, "Invalid start index");
            Debug.Assert(endIndex <= arr.Length - 1, "Invalid end Index");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            // additional check for correct min element index
            for (int i = startIndex; i <= endIndex; i++)
            {
                Debug.Assert(
                    arr[minElementIndex].CompareTo(arr[i]) <= 0,
                    "Element with index [" + minElementIndex + "] is not the smallest");
            }

            return minElementIndex;
        }

        /// <summary>
        /// Private swapping method
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="x">ref x</param>
        /// <param name="y">ref y</param>
        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        /// <summary>
        /// Private Binary search method
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="arr">searched array</param>
        /// <param name="value">searched value</param>
        /// <param name="startIndex">start index</param>
        /// <param name="endIndex">end index</param>
        /// <returns>integer value</returns>
        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
           where T : IComparable<T>
        {
            Debug.Assert(startIndex <= endIndex, "Start index should be smaller than or equal to end index!");
            Debug.Assert(startIndex >= 0, "Start index should be positive!");
            Debug.Assert(endIndex >= 0, "End index should be positive!");
            Debug.Assert(endIndex <= arr.Length - 1, "End index should be smaller than the length of the array!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}