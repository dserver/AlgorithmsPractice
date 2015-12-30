using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AlgorithmPractice.Problems.Sorting.HeapPQ.Solution;

namespace AlgorithmPractice.Problems.Sorting.HeapPQ.UnitTests
{
    class SimpleMaxPQTests
    {
        class InsertMethod
        {
            [Test]
            public void insert_5_items()
            {
                SimpleMaxPQ pq = new SimpleMaxPQ(10); // initial capacity of 10;
                for (int i = 0; i < 5; i++)
                    pq.insert(i); // add 0, 1, 2, 3, 4;

                Assert.AreEqual(4, pq.max(), "A1");
                Assert.AreEqual(5, pq.size(), "A2");
            }
        }
    }
}
