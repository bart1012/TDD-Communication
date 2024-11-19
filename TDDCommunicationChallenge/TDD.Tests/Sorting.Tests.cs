using Sorting;

namespace TDD.Tests
{
    public class Sorting
    {
        public static readonly object[] TestCasesForSortingMethods =
        {
            new object[]{new int[]{5,67,23,9,12,68,3,1}, new int[] {1,3,5,9,12,23,67,68} },
            new object[]{new int[]{86,23,12,96,7,3,1}, new int[] {1,3,7,12,23,86,96} },
            new object[]{new int[]{1,0}, new int[] {0,1} },
            new object[]{new int[]{}, new int[] {} }
        };

        [Test]
        [TestCaseSource(nameof(TestCasesForSortingMethods))]
        public void BubbleSort_SortsArray(int[] input, int[] expectedResult)
        {
            //Arrange
            BubbleSort bubbleSort = new();

            //Act
            bubbleSort.Sort(input);

            //Assert
            Assert.That(input, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCaseSource(nameof(TestCasesForSortingMethods))]
        public void SelectionSort_SortsArray(int[] input, int[] expectedResult)
        {
            //Arrange
            SelectionSort selectionSort = new();

            //Act
            selectionSort.Sort(input);

            //Assert
            Assert.That(input, Is.EqualTo(expectedResult));
        }
    }
}
