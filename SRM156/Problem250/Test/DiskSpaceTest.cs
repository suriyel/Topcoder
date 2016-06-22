
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem250;

namespace Test
{
    [TestFixture]
    public class DiskSpaceTest
    {
        private DiskSpace m_DiskSpace;
        [SetUp]
        public void Initial()
        {
            m_DiskSpace=new DiskSpace();
        }

        [Test]
        public void Test1()
        {
            var count = m_DiskSpace.minDrives(new int[] {300, 525, 110}, new int[] {350, 600, 115});
            Assert.AreEqual(count, 2);
        }

        [Test]
        public void Test2()
        {
            var count = m_DiskSpace.minDrives(new int[] { 1, 200, 200, 199, 200, 200 }, new int[] { 1000, 200, 200, 200, 200, 200 });
            Assert.AreEqual(count, 1);
        }

        [Test]
        public void Test3()
        {
            var count = m_DiskSpace.minDrives(new int[] { 750, 800, 850, 900, 950 }, new int[] { 800, 850, 900, 950, 1000 });
            Assert.AreEqual(count, 5);
        }

        [Test]
        public void Test4()
        {
            var count = m_DiskSpace.minDrives(new int[] {49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,
 49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49}, new int[] {50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,
 50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50});
            Assert.AreEqual(count, 49);
        }

        [Test]
        public void Test5()
        {
            var count = m_DiskSpace.minDrives(new int[] { 331, 242, 384, 366, 428, 114, 145, 89, 381, 170, 329, 190, 482, 246, 2, 38, 220, 290, 402, 385 }, new int[] { 992, 509, 997, 946, 976, 873, 771, 565, 693, 714, 755, 878, 897, 789, 969, 727, 765, 521, 961, 906 });
            Assert.AreEqual(count, 6);
        }
    }
}
