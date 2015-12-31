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

        private void sink(int k)
        {
            // sanity check
            if (k > size())
                throw new Exception("Cannot sink a value outside of bounds. Most likely caller is incorrect");

            while (true)
            {
                if (2 * k + 1 > size())
                    break; // pq[k] is in final position since it has no children

                int child1 = pq[2 * k + 1];
                if (pq[k] > child1) // is k greater than its first child?
                {
                    swap(k, 2 * k + 1); // then swap it
                    k = 2 * k + 1;
                }
                else if (2 * k + 2 <= size()) // does k have another child?
                {
                    if (pq[k] > pq[2 * k + 1]) // and is k greater than that child?
                    {
                        swap(k, 2 * k + 2); // then swap it
                        k = 2 * k + 2;
                    }
                    else
                        break;
                }
                else
                    break;
            }

            return;
            

            

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
