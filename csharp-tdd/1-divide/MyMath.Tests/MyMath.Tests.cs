using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(2, result[0, 1]);
            Assert.AreEqual(3, result[1, 0]);
            Assert.AreEqual(4, result[1, 1]);
        }

        [Test]
        public void Divide_ByZero_ReturnsNull()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            int[,] result = Matrix.Divide(matrix, 0);
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_ByOne_ReturnsSameValues()
        {
            int[,] matrix = { { 5, 10 }, { 15, 20 } };
            int[,] result = Matrix.Divide(matrix, 1);
            Assert.AreEqual(5, result[0, 0]);
            Assert.AreEqual(10, result[0, 1]);
            Assert.AreEqual(15, result[1, 0]);
            Assert.AreEqual(20, result[1, 1]);
        }

        [Test]
        public void Divide_NegativeNum_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 4, -8 }, { 12, -16 } };
            int[,] result = Matrix.Divide(matrix, -4);
            Assert.AreEqual(-1, result[0, 0]);
            Assert.AreEqual(2, result[0, 1]);
            Assert.AreEqual(-3, result[1, 0]);
            Assert.AreEqual(4, result[1, 1]);
        }

        [Test]
        public void Divide_SingleElementMatrix_ReturnsCorrectResult()
        {
            int[,] matrix = { { 100 } };
            int[,] result = Matrix.Divide(matrix, 10);
            Assert.AreEqual(10, result[0, 0]);
        }

        [Test]
        public void Divide_MatrixWithZeros_ReturnsZeros()
        {
            int[,] matrix = { { 0, 0 }, { 0, 0 } };
            int[,] result = Matrix.Divide(matrix, 5);
            Assert.AreEqual(0, result[0, 0]);
            Assert.AreEqual(0, result[0, 1]);
        }
    }
}
