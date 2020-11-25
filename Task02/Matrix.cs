namespace Task02
{
    /// <summary>
    /// Represents an integer matrix, which rows can be sorted in a selected pattern.
    /// </summary>
    public class Matrix
    {
        private readonly int[][] initialMatrix;
        private readonly MatrixOperations sortMethod;

        /// <summary>
        /// Constructs an instance of Matrix class.
        /// </summary>
        public Matrix(int[][] matrix, MatrixOperations sortMethod)
        {
            this.initialMatrix = matrix;
            this.sortMethod = sortMethod;
        }

        /// <summary>
        /// Sorts the initial matrix of integers in a specified pattern.
        /// </summary>
        /// <returns>A sorted matrix of integers.</returns>
        public int[][] Sort()
        {
            return this.sortMethod.Sort(this.initialMatrix);
        }
    }
}
