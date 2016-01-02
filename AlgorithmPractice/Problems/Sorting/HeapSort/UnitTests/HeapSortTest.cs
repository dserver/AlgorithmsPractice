using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HP = AlgorithmPractice.Problems.Sorting.HeapSort.Solution;

namespace AlgorithmPractice.Problems.Sorting.HeapSort.UnitTests
{
    [TestFixture]
    class HeapSortTest
    {
        [Test]
        public void sort_tenItemSort_trueIfSorted()
        {
            int[] a = { 9, 8, 5, 4, 1, 3, 2, 10, 6, 7 };
            int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            HP.HeapSort h = new HP.HeapSort();

            h.sort(a);

            for (int i = 0; i < a.Length; i++)
                Assert.AreEqual(b[i], a[i], "Sorting failed");

        }

    }
}
