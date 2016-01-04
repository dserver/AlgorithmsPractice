using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Problems.Sorting.HeapPQ.Solution
{

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
            max_capacity = a.Length;
            insert_point = 0;
            pq = new int[max_capacity];

            for (int j = 0; j < a.Length; j++)
                insert(a[j]);
        }

        // insert key into the PQ
        public void insert(int key)
        {
            if (insert_point < max_capacity) // if the heap still has room just add at first space
            {
                pq[insert_point] = key;
                bubbleUp(insert_point);
                insert_point++;
            }
            else
            {
                if (pq[0] < key) // replace minimum element
                {
                    pq[0] = key;
                    sink(0); // put root in correct position after replacement
                }
            }

        }

        public int min()
        {
            if (size() == 0)
                throw new Exception("PQ is empty. No min to return");

            return pq[0];
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

                // check for no child
                if (2 * k + 1 >= size())
                    return;

                // check for only 1 child
                if (2 * k + 2 >= size())
                {
                    if (pq[k] > pq[2 * k + 1]) // is element greater than that one child?
                    {
                        swap(k, 2 * k + 1); // then swap it
                        k = 2 * k + 1; // continue looping.
                    }
                    else
                        return; // element is in final position
                }
                else // there are two children, we need to check both
                {
                    if (pq[2 * k + 1] > pq[2 * k + 2] && pq[k] > pq[2 * k + 2])
                    {
                        swap(k, 2 * k + 2); // then swap it
                        k = 2 * k + 2; // continue looping.
                    }
                    else if (pq[2 * k + 1] < pq[2 * k + 2] && pq[k] > pq[2 * k + 1])
                    {
                        swap(k, 2 * k + 1); // then swap it
                        k = 2 * k + 1; // continue looping.
                    }
                    else
                        return;
                }
            }
            
        }

        
        private void bubbleUp(int k)
        {
            while (k > 0 && pq[k/2] > pq[k])
            {
                swap(k, k / 2);
                k = k / 2;
            }
        }

        public void swap(int i, int k)
        {
            int temp = pq[i];
            pq[i] = pq[k];
            pq[k] = temp;
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

        public int[] toSortedArray()
        {
            int[] r = new int[pq.Length];
            Array.Copy(pq,
                r, r.Length);
            Array.Sort(r);
            return r;
        }
    }
}
