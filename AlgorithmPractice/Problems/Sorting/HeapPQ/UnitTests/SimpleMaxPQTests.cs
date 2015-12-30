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
        [TestFixture]
        class InsertMethod // contains sufficient tests of size and max as well
        {
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
