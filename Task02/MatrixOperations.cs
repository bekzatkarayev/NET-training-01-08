namespace Task02
{
    /// <summary>
    /// Contains all methods that are required to perform sorting of rows of the integer matrix.
    /// </summary>
    public abstract class MatrixOperations
    {
        /// <summary>
        /// Defines a method that sorts rows of an integer matrix.
        /// </summary>
        /// <param name="matrix">An initial unsorted matrix.</param>
        /// <returns>A sorted matrix of integers.</returns>
        public abstract int[][] Sort(int[][] matrix);

        /// <summary>
        /// Calculates sum of all elements of an integer array.
        /// </summary>
        /// <param name="row">An integer array.</param>
        /// <returns>Sum of elements of an integer array.</returns>
        protected virtual int GetSumOfElements(int[] row)
        {
            int sum = 0;
            foreach (var element in row)
            {
                sum += element;
            }

            return sum;
        }

        /// <summary>
        /// Finds the largest element of an integer array.
        /// </summary>
        /// <param name="row">An integer array.</param>
        /// <returns>A signed integer.</returns>
        protected virtual int GetMaxElement(int[] row)
        {
            int max = row[0];
            foreach (var element in row)
            {
                if (max < element)
                {
                    max = element;
                }
            }

            return max;
        }

        /// <summary>
        /// Finds the smallest element of an integer array.
        /// </summary>
        /// <param name="row">An integer array.</param>
        /// <returns>A signed integer.</returns>
        protected virtual int GetMinElement(int[] row)
        {
            int min = row[0];
            foreach (var element in row)
            {
                if (min > element)
                {
                    min = element;
                }
            }

            return min;
        }
    }
}
