﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Problems.Sorting.HeapPQ.Solution
{
    class ArrayHeapPQ
    {
    }

    class SimpleMaxPQ
    {
        private int max_capacity;
        private List<int> pq;
        private int insert_index = 1;

        // create PQ with initial capacity max
        public SimpleMaxPQ(int max)
        {
            max_capacity = max;
            pq = new List<int>();
        }

        // create PQ from array A
        public SimpleMaxPQ(int[] a)
        {
            pq = new List<int>();
            for (int i = 0; i < a.Length; i++)
                this.insert(a[i]);
        }

        // insert key into the PQ
        public void insert(int key)
        {
            pq[insert_index] = key;
            swim(insert_index);
            insert_index++;
        }

        // balance the heap from the child at position k
        private void swim(int k)
        {
            int val = pq[k];
            int parent_index = k / 2;
            int parent = pq[parent_index];
            while (k > 1 && pq[k / 2] < pq[k])
            {
                pqSwap(k / 2, k);
                k = k / 2;
            }

            return;
        }

        private void pqSwap(int i, int j)
        {
            int temp = pq[i];
            pq[i] = pq[j];
            pq[j] = temp;

        }

        // return max item in PQ.
        public int max()
        {
            return pq[1];
        }

        // return and remove largest item in PQ
        public int delMax()
        {
            int r = pq[1];
            pqSwap(insert_index, 1);
            insert_index--;
            pqSink(1);

            return r;
        }

        public void pqSink(int k)
        {

        }

        // check if PQ has any items in it.
        public bool isEmpty()
        {
            return true;
        }

        // return number of items in the PQ
        public int size()
        {
            return 0;
        }
    }
}
