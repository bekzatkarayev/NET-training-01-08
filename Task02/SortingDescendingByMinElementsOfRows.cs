namespace Task02
{
    /// <summary>
    /// Contains implementation of a method that sorts rows of an integer matrix by the smallest element of each row in descending order. 
    /// </summary>
    public class SortingDescendingByMinElementsOfRows : MatrixOperations
    {
        /// <summary>
        /// Sorts an integer matrix by the smallest element of each row in descending order.
        /// </summary>
        /// <param name="matrix">An array of integer arrays.</param>
        /// <returns>A sorted array of integer arrays.</returns>
        public override int[][] Sort(int[][] matrix)
        {
            var mins = new int[matrix.Length];

            for (int index = 0; index < mins.Length; index++)
            {
                mins[index] = this.GetMinElement(matrix[index]);
            }

            for (int index = 0; index < mins.Length; index++)
            {
                for (int runner = 0; runner < mins.Length - 1; runner++)
                {
                    if (mins[runner] < mins[runner + 1])
                    {
                        int temp = mins[runner];
                        mins[runner] = mins[runner + 1];
                        mins[runner + 1] = temp;
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
