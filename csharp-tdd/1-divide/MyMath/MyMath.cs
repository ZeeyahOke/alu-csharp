using System;

namespace MyMath
{
    /// <summary>
    /// Provides matrix math operations.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix by a given number.
        /// </summary>
        /// <param name="matrix">The 2D integer matrix to divide.</param>
        /// <param name="num">The divisor.</param>
        /// <returns>A new matrix with each element divided by num, or null on error.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            try
            {
                if (num == 0)
                    throw new DivideByZeroException();

                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] result = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        result[i, j] = matrix[i, j] / num;

                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
