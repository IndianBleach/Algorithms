using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Arrays
{
    public static class ArraySortLibrary
    {
        private static void Swap(ref int left, ref int right)
        {
            int tmp = left;
            left = right;
            right = tmp;
        }

        private static int GetPivotIndex(double[] array, int minIndex, int maxIndex)
        { 
            int pivotIndex = minIndex - 1;

            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] <= array[maxIndex])
                {
                    pivotIndex++;
                    Swap(ref array[pivotIndex], ref array[maxIndex]);
                }
            }

            return pivotIndex;
        }

        public static double[] QuickSort(double[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return array;


            int pivot = GetPivotIndex(double[] array, int minIndex, int maxIndex);

            QuickSort(array, minIndex, pivot-1);

            QuickSort(array, pivot + 1, maxIndex);


            return array;

        }
        public static ICollection<double> RemoveDuplicatesFromSortedArray(double[] array)
        {
            if (array.Length == 0) return array;

            ICollection<double> result = new List<double>();
            int startIndex = 0;
            result.Add(array[startIndex]);

            for (int j = 1; j < array.Length; j++)
            {
                if (array[j] != array[startIndex])
                    result.Add(array[j]);

                startIndex++;
            }

            return result;
        }
    }
}
