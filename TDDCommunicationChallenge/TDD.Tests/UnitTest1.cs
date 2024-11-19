using TDDCommunicationChallenge;

namespace TDD.Tests
{
    public class Tests
    {
        NumberSum numberSum;

        private static readonly object[] TestCasesForNumberSum =
        {
            new object[]{new int[] { 5, 2, 6, 10, 22 }, 21},
            new object[]{new int[] { 1, 2, 3, 4, 5 }, 9},
            new object[]{new int[] { 1 }, 0},
            new object[]{new int[] { 1,2 }, 0},
            new object[]{new int[] { 1,2,3 }, 2},


        };

        [TestCaseSource(nameof(TestCasesForNumberSum))]
        [Test]
        public void NumberSum_returns_intended_number(int[] input, int expectedResult)
        {
            //Arrange
            numberSum = new();

            //Act
            var methodCallResult = numberSum.SumMiddleNumbers(input);

            //Assert
            Assert.That(methodCallResult == expectedResult);

        }
    }
}