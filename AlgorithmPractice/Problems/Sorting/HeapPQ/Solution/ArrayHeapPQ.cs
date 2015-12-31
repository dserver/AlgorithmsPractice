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

        // create PQ with initial capacity max
        public SimpleMaxPQ(int max)
        {
            max_capacity = max;
            insert_point = 0;
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
