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
    }
}
