namespace Task02
{
    /// <summary>
    /// Contains implementation of a method that sorts rows of an integer matrix by sum of their elements in ascending order. 
    /// </summary>
    public class SortingAscendingBySumsOfElementsOfRows : MatrixOperations
    {
        /// <summary>
        /// Sorts an integer matrix by sum of the elements in each row in ascending order.
        /// </summary>
        /// <param name="matrix">An array of integer arrays.</param>
        /// <returns>A sorted array of integer arrays.</returns>
        public override int[][] Sort(int[][] matrix)
        {
            var sums = new int[matrix.Length];

            for (int index = 0; index < sums.Length; index++)
            {
                sums[index] = this.GetSumOfElements(matrix[index]);
            }

            for (int index = 0; index < sums.Length; index++)
            {
                for (int runner = 0; runner < sums.Length - 1; runner++)
                {
                    if (sums[runner] > sums[runner + 1])
                    {
                        int temp = sums[runner];
                        sums[runner] = sums[runner + 1];
                        sums[runner + 1] = temp;
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
