using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Problems.Sorting.MergeSort.Solution
{
    class MergeSort
    {
        private int[] aux;
        public void sort(int[] a)
        {
            aux = new int[a.Length];

        }

        public void merge(int[] a, int s1_low, int s1_high, int s2_low, int s2_high)
        {
            int i = s1_low;
            int j = s2_low;

            for (int z = s1_low; z < s2_high + 1; z++)
                aux[z] = a[z];

            for (; i <= s2_high; i++)
            {

            }
        }
    }
}
