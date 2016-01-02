using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmPractice.Problems.Sorting.Interfaces;

namespace AlgorithmPractice.Problems.Sorting.InsertionSort.Solution
{
    class InsertSort : SortingAlgorithm
    {

        public void sort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
                for (int j = i; j > 0; j--)
                    if (a[j - 1] <= a[j])
                        swap(a, j - 1, j);
        }

        private void swap(int[] a, int k, int m)
        {
            int temp = a[k];
            a[k] = a[m];
            a[m] = temp;
        }
    }
}
