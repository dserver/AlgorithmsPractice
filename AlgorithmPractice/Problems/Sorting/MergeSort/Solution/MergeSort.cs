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
            for (int z = s1_low; z <= s2_high; z++)
                aux[z] = a[z]; // copy to auxillary array

            int i = s1_low;
            int j = s2_low;
            for (int k = s1_low; k <= s2_high; k++)
            {
                if (i == s2_low)
                    a[k] = aux[j++];
                else if (j == s2_high + 1)
                    a[k] = aux[i++];
                else
                {
                    // to do
                }
            }
        }
    }
}
