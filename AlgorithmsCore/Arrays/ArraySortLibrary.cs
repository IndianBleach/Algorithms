using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore.Arrays
{
    public static class ArraySortLibrary
    {
        public static ICollection<double> RemoveDuplicatesFromSortedArray(double[] array)
        {
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
