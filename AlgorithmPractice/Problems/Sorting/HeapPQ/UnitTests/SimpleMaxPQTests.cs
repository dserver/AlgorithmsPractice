using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AlgorithmPractice.Problems.Sorting.HeapPQ.Solution;
using C5;

namespace AlgorithmPractice.Problems.Sorting.HeapPQ.UnitTests
{
    [TestFixture]
    class SimpleMaxPQTests
    {
        [Test]
        public void insertMethod_add5items_returnsNoExceptionThrown()
        {
            int[] a = { 5, 1, 3, 2, 4 };
            SimpleMaxPQ m = new SimpleMaxPQ(a);
            Assert.IsTrue(true, "Created object without issues");
        }

        [Test]
        public void minMethod_add5ItemsGetMinEachTime_trueIfMinsAreRight()
        {
            int[] a = new int[5];
            int c = 5;
            for (int j = 0; j < a.Length; j++)
                a[j] = c--;

            SimpleMaxPQ m = new SimpleMaxPQ(6);
            for (int j = 0; j < a.Length; j++)
            {
                m.insert(a[j]);
                int min = m.min();
                Assert.IsTrue(a[j] == min, "Minimum value was incorrect");
            }

        }

        [Test]
        public void delMin_testSortedOrderTenItems_trueIfSorted()
        {
            int[] a = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            SimpleMaxPQ m = new SimpleMaxPQ(10);
            for (int i = 0; i < a.Length; i++)
                m.insert(a[i]);

            for (int i = 0; i < b.Length; i++)
            {
                int t = m.delMin();
                Assert.AreEqual(b[i], t, "Test sorted order not working");
            }


        }

        [Test]
        public void size_insertItems_trueIfSizeIsRight()
        {
            SimpleMaxPQ m = new SimpleMaxPQ(10);
            for (int i=0; i < 10; i++)
            {
                Assert.IsTrue(m.size() == i, "Size function not working properly");
                m.insert(i);
            }
        }

        [Test]
        public void size_insertAndDelItems_trueIfSizeIsRight()
        {
            SimpleMaxPQ m = new SimpleMaxPQ(10);
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(m.size() == i, "Size function not working properly");
                m.insert(i);
            }

            for (int i=10; i > 0; i--)
            {
                Assert.AreEqual(i, m.size(), "Size function after deleting not working correctly.");
                m.delMin();
            }
        }

        [Test]
        public void delMax_insertManyRandom_TrueIfC5PQreturnsSame()
        {
            IntervalHeap<int> correct_pq = new IntervalHeap<int>();
            SimpleMaxPQ my_pq = new SimpleMaxPQ(10);

            Random r = new Random();
            for (int i=0; i < 1000; i++)
            {
                int n = r.Next(0, 100000);
                correct_pq.Add(n);
                my_pq.insert(n);
            }

            int[] correct_sorted = correct_pq.ToArray();
            Array.Sort(correct_sorted);
            int[] mine = my_pq.toSortedArray();
            

            for (int i=990; i < 1000; i++)
            {
                Assert.AreEqual(correct_sorted[i], mine[i - 990]);
            }
        }
            [Test]
            public void insert_5_items()
            {
                SimpleMaxPQ pq = new SimpleMaxPQ(10); // initial capacity of 10;
                for (int i = 0; i < 5; i++)
                    pq.insert(i); // add 0, 1, 2, 3, 4;

                Assert.AreEqual(4, pq.max(), "A1");
                Assert.AreEqual(5, pq.size(), "A2");

                pq.insert(7);
                Assert.AreEqual(6, pq.size(), "A3");
            }

            [Test]
            public void insert_20_maxsize_15_items()
            {
                SimpleMaxPQ pq = new SimpleMaxPQ(15); // initial capacity of 10;
                for (int i = 0; i < 20; i++)
                    pq.insert(i); // add 0, 1, 2, 3, 4;

                Assert.AreEqual(19, pq.max(), "B1");
                Assert.AreEqual(20, pq.size(), "B2");

                pq.insert(22);
                Assert.AreEqual(21, pq.size(), "B3");
            }

            [Test]
            public void insert_20_maxsize_15_items_reverse()
            {
                SimpleMaxPQ pq = new SimpleMaxPQ(15); // initial capacity of 15;
                for (int i = 20; i > 0; i--)
                    pq.insert(i);

                Assert.AreEqual(19, pq.max(), "C1");
                Assert.AreEqual(20, pq.size(), "C2");
            }
        }

        [TestFixture]
        public class DelMax
        {
            [Test]
            public void delMax_1_item()
            {
                SimpleMaxPQ pq = new SimpleMaxPQ(5);
                pq.insert(13);

                Assert.AreEqual(13, pq.delMax(), "D1");
                pq.insert(22);
                Assert.AreEqual(22, pq.delMax(), "D2");
            }

            [Test]
            public void insert_20_maxsize_15_items_reverse()
            {
                SimpleMaxPQ pq = new SimpleMaxPQ(15); // initial capacity of 15;
                for (int i = 20; i > 0; i--)
                    pq.insert(i); 

                Assert.AreEqual(19, pq.delMax(), "EC1");
                Assert.AreEqual(19, pq.size(), "EC2");

                pq.insert(5);
                Assert.AreEqual(18, pq.delMax(), "E4");
                Assert.AreEqual(20, pq.size(), "E5");
            }
        }
    }
}
