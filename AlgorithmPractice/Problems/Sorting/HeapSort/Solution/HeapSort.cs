using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Problems.Sorting.HeapSort.Solution
{
    public class HeapSort
    {
        int[] pq;
        int fake_length;

        public void sort(ref int[] a)
        {
            this.pq = a; // add reference so other functions can use
            this.fake_length = a.Length - 1;

            // heapify
            int z = a.Length - 1; // position where we start "heapifying"
            // we need to find the position first
            while (2 * z + 1 > a.Length - 1)
                z--;

            // z now is first heap that needs to be heapified.
            int ip = a.Length - 1; // points so position where we swap root node to.
            for (int i=0; i < a.Length; i++)
            {
                swap(0, ip); // put top node in last position
                fake_length--; // "remove" last element
                sink(0); // put new root node in new position.

            }

            return; // a should be sorted.


        }

        private void sink(int k)
        {
            // check for two children.
            if (2 * k + 2 <= fake_length)
            {
                int c1 = 2 * k + 1;
                int c2 = 2 * k + 2;
                if (pq[c1] >= pq[c2] && pq[k] <= pq[c1]) // test for swap with first child
                {
                    swap(c1, k);
                    k = c1;
                }
                else if (pq[c2] > pq[c1] && pq[k] <= pq[c2])
                {
                    swap(c2, k);
                    k = c2;
                }
                else return;
            }
            else if (2 * k + 1 <= fake_length) // check for one child
            {
                if (pq[k] <= pq[2 * k + 1])
                {
                    swap(k, 2 * k + 1);
                    k = 2 * k + 1;
                }
                else return;
            }
            else return; // no children
        }

        private void swap(int i, int j)
        {
            int t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }
    }
}
