using NUnit.Framework;
using Task02;

namespace Task02.Tests
{
    public class MethodTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sort_SampleMatrix_ReturnsMatrixSortedAscendingBySumsOfElementsOfRows()
        {
            // Arrange
            var arr = new int[][]
                                 {
                                  new int[] { -32, 60, -80, -13, -6 }, new int[] { 9, -31, -33, 67, -3 },
                                  new int[] { -54, 22, 26, -46, 17 }, new int[] { -38, -64, -61, 28, 14 },
                                  new int[] { -48, 58, -40, 74, 48 }, new int[] { -1, 57, -30, -69, 35 },
                                  new int[] { -96, -12, -66, 64, 87 }, new int[] { 48, 32, 90, -78, -96 },
                                  new int[] { 33, -95, -24, -67, -59 }, new int[] { -55, -60, 5, 65, -59 }
                                 };

            var expected = new int[][]
                                      {
                                       new int[] { 33, -95, -24, -67, -59 }, new int[] { -38, -64, -61, 28, 14 },
                                       new int[] { -55, -60, 5, 65, -59 }, new int[] { -32, 60, -80, -13, -6 },
                                       new int[] { -54, 22, 26, -46, 17 }, new int[] { -96, -12, -66, 64, 87 },
                                       new int[] { -1, 57, -30, -69, 35 }, new int[] { 48, 32, 90, -78, -96 },
                                       new int[] { 9, -31, -33, 67, -3 }, new int[] { -48, 58, -40, 74, 48 }
                                      };

            var matrix = new Matrix(arr, new SortingAscendingBySumsOfElementsOfRows());

            // Act
            var actual = matrix.Sort();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sort_SampleMatrix_ReturnsMatrixSortedDescendingBySumsOfElementsOfRows()
        {
            // Arrange
            var arr = new int[][]
                                 {
                                  new int[] { -32, 60, -80, -13, -6 }, new int[] { 9, -31, -33, 67, -3 },
                                  new int[] { -54, 22, 26, -46, 17 }, new int[] { -38, -64, -61, 28, 14 },
                                  new int[] { -48, 58, -40, 74, 48 }, new int[] { -1, 57, -30, -69, 35 },
                                  new int[] { -96, -12, -66, 64, 87 }, new int[] { 48, 32, 90, -78, -96 },
                                  new int[] { 33, -95, -24, -67, -59 }, new int[] { -55, -60, 5, 65, -59 }
                                 };

            var expected = new int[][]
                                      {
                                       new int[] { -48, 58, -40, 74, 48 }, new int[] { 9, -31, -33, 67, -3 },
                                       new int[] { 48, 32, 90, -78, -96 }, new int[] { -1, 57, -30, -69, 35 },
                                       new int[] { -96, -12, -66, 64, 87 }, new int[] { -54, 22, 26, -46, 17 },
                                       new int[] { -32, 60, -80, -13, -6 }, new int[] { -55, -60, 5, 65, -59 },
                                       new int[] { -38, -64, -61, 28, 14 }, new int[] { 33, -95, -24, -67, -59 }
                                      };

            var matrix = new Matrix(arr, new SortingDescendingBySumsOfElementsOfRows());

            // Act
            var actual = matrix.Sort();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sort_SampleMatrix_ReturnsMatrixSortedAscendingByMaxElementsOfRows()
        {
            // Arrange
            var arr = new int[][]
                                 {
                                  new int[] { -32, 60, -80, -13, -6 }, new int[] { 9, -31, -33, 67, -3 },
                                  new int[] { -54, 22, 26, -46, 17 }, new int[] { -38, -64, -61, 28, 14 },
                                  new int[] { -48, 58, -40, 74, 48 }, new int[] { -1, 57, -30, -69, 35 },
                                  new int[] { -96, -12, -66, 64, 87 }, new int[] { 48, 32, 90, -78, -96 },
                                  new int[] { 33, -95, -24, -67, -59 }, new int[] { -55, -60, 5, 65, -59 }
                                 };

            var expected = new int[][]
                                      {
                                       new int[] { -54, 22, 26, -46, 17 }, new int[] { -38, -64, -61, 28, 14 },
                                       new int[] { 33, -95, -24, -67, -59 }, new int[] { -1, 57, -30, -69, 35 },
                                       new int[] { -32, 60, -80, -13, -6 }, new int[] { -55, -60, 5, 65, -59 },
                                       new int[] { 9, -31, -33, 67, -3 }, new int[] { -48, 58, -40, 74, 48 },
                                       new int[] { -96, -12, -66, 64, 87 }, new int[] { 48, 32, 90, -78, -96 }
                                      };

            var matrix = new Matrix(arr, new SortingAscendingByMaxElementsOfRows());

            // Act
            var actual = matrix.Sort();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sort_SampleMatrix_ReturnsMatrixSortedDescendingByMaxElementsOfRows()
        {
            // Arrange
            var arr = new int[][]
                                 {
                                  new int[] { -32, 60, -80, -13, -6 }, new int[] { 9, -31, -33, 67, -3 },
                                  new int[] { -54, 22, 26, -46, 17 }, new int[] { -38, -64, -61, 28, 14 },
                                  new int[] { -48, 58, -40, 74, 48 }, new int[] { -1, 57, -30, -69, 35 },
                                  new int[] { -96, -12, -66, 64, 87 }, new int[] { 48, 32, 90, -78, -96 },
                                  new int[] { 33, -95, -24, -67, -59 }, new int[] { -55, -60, 5, 65, -59 }
                                 };

            var expected = new int[][]
                                      {
                                       new int[] { 48, 32, 90, -78, -96 }, new int[] { -96, -12, -66, 64, 87 },
                                       new int[] { -48, 58, -40, 74, 48 }, new int[] { 9, -31, -33, 67, -3 },
                                       new int[] { -55, -60, 5, 65, -59 }, new int[] { -32, 60, -80, -13, -6 },
                                       new int[] { -1, 57, -30, -69, 35 }, new int[] { 33, -95, -24, -67, -59 },
                                       new int[] { -38, -64, -61, 28, 14 }, new int[] { -54, 22, 26, -46, 17 }
                                      };

            var matrix = new Matrix(arr, new SortingDescendingByMaxElementsOfRows());

            // Act
            var actual = matrix.Sort();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sort_SampleMatrix_ReturnsMatrixSortedAscendingByMinElementsOfRows()
        {
            // Arrange
            var arr = new int[][]
                                 {
                                  new int[] { -32, 60, -80, -13, -6 }, new int[] { 9, -31, -33, 67, -3 },
                                  new int[] { -54, 22, 26, -46, 17 }, new int[] { -38, -64, -61, 28, 14 },
                                  new int[] { -48, 58, -40, 74, 48 }, new int[] { -1, 57, -30, -69, 35 },
                                  new int[] { -96, -12, -66, 64, 87 }, new int[] { 48, 32, 90, -78, -96 },
                                  new int[] { 33, -95, -24, -67, -59 }, new int[] { -55, -60, 5, 65, -59 }
                                 };

            var expected = new int[][]
                                      {
                                       new int[] { -96, -12, -66, 64, 87 }, new int[] { 48, 32, 90, -78, -96 },
                                       new int[] { 33, -95, -24, -67, -59 }, new int[] { -32, 60, -80, -13, -6 },
                                       new int[] { -1, 57, -30, -69, 35 }, new int[] { -38, -64, -61, 28, 14 },
                                       new int[] { -55, -60, 5, 65, -59 }, new int[] { -54, 22, 26, -46, 17 },
                                       new int[] { -48, 58, -40, 74, 48 }, new int[] { 9, -31, -33, 67, -3 }
                                      };

            var matrix = new Matrix(arr, new SortingAscendingByMinElementsOfRows());

            // Act
            var actual = matrix.Sort();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sort_SampleMatrix_ReturnsMatrixSortedDescendingByMinElementsOfRows()
        {
            // Arrange
            var arr = new int[][]
                                 {
                                  new int[] { -32, 60, -80, -13, -6 }, new int[] { 9, -31, -33, 67, -3 },
                                  new int[] { -54, 22, 26, -46, 17 }, new int[] { -38, -64, -61, 28, 14 },
                                  new int[] { -48, 58, -40, 74, 48 }, new int[] { -1, 57, -30, -69, 35 },
                                  new int[] { -96, -12, -66, 64, 87 }, new int[] { 48, 32, 90, -78, -96 },
                                  new int[] { 33, -95, -24, -67, -59 }, new int[] { -55, -60, 5, 65, -59 }
                                 };

            var expected = new int[][]
                                      {
                                       new int[] { 9, -31, -33, 67, -3 }, new int[] { -48, 58, -40, 74, 48 },
                                       new int[] { -54, 22, 26, -46, 17 }, new int[] { -55, -60, 5, 65, -59 },
                                       new int[] { -38, -64, -61, 28, 14 }, new int[] { -1, 57, -30, -69, 35 },
                                       new int[] { -32, 60, -80, -13, -6 }, new int[] { 33, -95, -24, -67, -59 },
                                       new int[] { -96, -12, -66, 64, 87 }, new int[] { 48, 32, 90, -78, -96 }
                                      };

            var matrix = new Matrix(arr, new SortingDescendingByMinElementsOfRows());

            // Act
            var actual = matrix.Sort();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}