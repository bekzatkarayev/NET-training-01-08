namespace Task02
{
    /// <summary>
    /// Contains implementation of a method that sorts rows of an integer matrix by the largest element of each row in ascending order. 
    /// </summary>
    public class SortingAscendingByMaxElementsOfRows : MatrixOperations
    {
        /// <summary>
        /// Sorts an integer matrix by the largest element of each row in ascending order.
        /// </summary>
        /// <param name="matrix">An array of integer arrays.</param>
        /// <returns>A sorted array of integer arrays.</returns>
        public override int[][] Sort(int[][] matrix)
        {
            var maxs = new int[matrix.Length];

            for (int index = 0; index < maxs.Length; index++)
            {
                maxs[index] = this.GetMaxElement(matrix[index]);
            }

            for (int index = 0; index < maxs.Length; index++)
            {
                for (int runner = 0; runner < maxs.Length - 1; runner++)
                {
                    if (maxs[runner] > maxs[runner + 1])
                    {
                        int temp = maxs[runner];
                        maxs[runner] = maxs[runner + 1];
                        maxs[runner + 1] = temp;
                        int[] tempArray = matrix[runner];
                        matrix[runner] = matrix[runner + 1];
                        matrix[runner + 1] = tempArray;
                    }
                }
            }

            return matrix;
        }
    }
}
