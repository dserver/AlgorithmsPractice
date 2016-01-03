using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AlgorithmPractice.Problems.Sorting.HeapPQ.Solution;

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

    }
}
