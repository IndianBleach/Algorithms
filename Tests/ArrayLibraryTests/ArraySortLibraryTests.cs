using AlgorithmsCore.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.ArrayLibraryTests
{
    public class ArraySortLibraryTests
    {
        [Fact]
        public void QuickSortTest()
        {
            double[] input = new double[] { 3, 2, 1, 5, 4, 6, 7 };

            Assert.Equal(
                new double[] { 1, 2, 3, 4, 5, 6, 7 },
                ArraySortLibrary.QuickSort(input, 0, input.Length - 1));
        }

        [Fact]
        public void RemoveDuplicatesFromSortedArrayTest()
        {
            // sorted ascending
            Assert.Equal(
                new List<double>() { 2, 4, 5, 7, 21, 42, 57 },
                ArraySortLibrary
                .RemoveDuplicatesFromSortedArray(new double[] { 2, 4, 4, 5, 7, 21, 42, 42, 57, 57}));

            Assert.Equal(
                new List<double>() { 2, 4, 5, 21, 42, 53 },
                ArraySortLibrary
                .RemoveDuplicatesFromSortedArray(new double[] { 2, 2, 2, 4, 5, 21, 42, 42, 53 }));

            // sorted descending
            Assert.Equal(
                new List<double>() { 9, 8, 5, 2, 1 },
                ArraySortLibrary
                .RemoveDuplicatesFromSortedArray(new double[] { 9,9,8,5,2,1,1}));

            Assert.Equal(
                new List<double>() { 92, 47, 23, 21, 1 },
                ArraySortLibrary
                .RemoveDuplicatesFromSortedArray(new double[] { 92, 47, 47, 23, 21, 21, 1, 1 }));

            // other
            Assert.Equal(
                new List<double>() {},
                ArraySortLibrary
                .RemoveDuplicatesFromSortedArray(new double[] {}));

            Assert.Equal(
                new List<double>() { 1 },
                ArraySortLibrary
                .RemoveDuplicatesFromSortedArray(new double[] {1 }));
        }
    }
}
