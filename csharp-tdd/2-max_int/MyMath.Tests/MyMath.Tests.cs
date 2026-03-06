using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_RegularList_ReturnsMax()
        {
            Assert.AreEqual(9, Operations.Max(new List<int> { 1, 9, 3, 7, 2 }));
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(new List<int>()));
        }

        [Test]
        public void Max_SingleElement_ReturnsThatElement()
        {
            Assert.AreEqual(42, Operations.Max(new List<int> { 42 }));
        }

        [Test]
        public void Max_AllNegative_ReturnsLeastNegative()
        {
            Assert.AreEqual(-1, Operations.Max(new List<int> { -1, -5, -3 }));
        }

        [Test]
        public void Max_AllSame_ReturnsThatValue()
        {
            Assert.AreEqual(5, Operations.Max(new List<int> { 5, 5, 5 }));
        }

        [Test]
        public void Max_ContainsZero_ReturnsCorrectMax()
        {
            Assert.AreEqual(3, Operations.Max(new List<int> { 0, 1, 3, 2 }));
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }

        [Test]
        public void Max_MaxAtStart_ReturnsMax()
        {
            Assert.AreEqual(100, Operations.Max(new List<int> { 100, 1, 2, 3 }));
        }

        [Test]
        public void Max_MaxAtEnd_ReturnsMax()
        {
            Assert.AreEqual(100, Operations.Max(new List<int> { 1, 2, 3, 100 }));
        }
    }
}
