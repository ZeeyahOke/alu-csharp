using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            Assert.AreEqual(1, Operations.Add(3, -2));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        [Test]
        public void Add_WithZero_ReturnsSameNumber()
        {
            Assert.AreEqual(7, Operations.Add(7, 0));
        }

        [Test]
        public void Add_BothZero_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Add(0, 0));
        }

        [Test]
        public void Add_LargeNumbers_ReturnsSum()
        {
            Assert.AreEqual(2000000, Operations.Add(1000000, 1000000));
        }
    }
}
