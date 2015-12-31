using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Problems.Sorting.HeapPQ.Solution
{
    class ArrayHeapPQ
    {
    }

    // Returns the max N items
    class SimpleMaxPQ
    {
        private int max_capacity; // this should be set to the max N items you want
        private int insert_point; // place where new elements are added to the array/PQ
        private int[] pq; // the heap structure

        // create PQ with initial capacity max
        public SimpleMaxPQ(int max)
        {
            max_capacity = max;
            insert_point = 0;
            pq = new int[max_capacity];
        }

        // create PQ from array A
        public SimpleMaxPQ(int[] a)
        {

        }

        // insert key into the PQ
        public void insert(int key)
        {

        }

        // return max item in PQ.
        public int max()
        {
            return 0;
        }

        // return and remove smallest item in PQ
        public int delMin()
        {
            if (size() == 0)
                throw new Exception("Cannot delete minimum if PQ is empty");

            int min = pq[0]; // save minimum so we can return it
            pq[0] = pq[--insert_point]; // replace top with last child node
            sink(0); // place new root in correct position

            return min; // return old minimum value
        }

        // check if PQ has any items in it.
        public bool isEmpty()
        {
            return true;
        }

        // return number of items in the PQ
        public int size()
        {
            return insert_point;
        }
    }
}
