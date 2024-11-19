using TDDCommunicationChallenge;

namespace TDD.Tests;

public class KataSolverTests
{
    KataSolver kataSolver;

    private static readonly object[] TestCasesForNumberSum =
    {
        new object[]{new int[] { 5, 2, 6, 10, 22 }, 21 },
        new object[]{new int[] { 1, 2, 3, 4, 5 }, 9 },
        new object[]{new int[] { }, 0 },
        new object[]{new int[] { 1 }, 0 },
        new object[]{new int[] { 1, 2 }, 0 },
        new object[]{new int[] { 1, 2, 3 }, 2 },
    };

    private static readonly object[] TestCasesForCalculateMean =
    {
        new object[] { new int[] { 1, 2, 3 }, 2 },
        new object[] { new int[] { 40, 16, 5, 8 }, 17.25 },
        new object[] { new int[] { }, 0 }
    };

    private static readonly object[] TestCasesForSumAsciiValues =
    {
        new object[] { "northcoders", 1195 },
        new object[] { "Northcoders", 1163},
        new object[] { "a", 97 },
        new object[] { "", 0 },
        new object[] { null, 0 },
        new object[] { "a@", 97 },
        new object[] { "a9", 97+57 }
    };

    private static readonly object[] TestCasesForEvaluateLecture =
    {
        new object[] { "LLLDDD", "NEUTRAL" },
        new object[] { "", "NEUTRAL" },
        new object[] { "LLLLDDD", "DISLIKE" },
        new object[] { "LLLDDDD", "LIKE" },
        new object[] { null, "NEUTRAL" },
    };

    private static readonly object[] TestCasesForCreateCaesarCipher =
{
        new object[] { "northcoders", "abegupbqref" },
        new object[] { "", "" },
        new object[] { "abegupbqref", "northcoders" },
        new object[] { "Northcoders", "Abegupbqref" },
        new object[] { "Northcoders 13", "Abegupbqref 13" },
    };

    [Test]
    [TestCaseSource(nameof(TestCasesForNumberSum))]
    public void NumberSum_returns_intended_number(int[] input, int expectedResult)
    {
        //Arrange
        kataSolver = new();

        //Act
        var methodCallResult = kataSolver.SumMiddleNumbers(input);

        //Assert
        Assert.That(methodCallResult == expectedResult);

    }

    [Test]
    [TestCaseSource(nameof(TestCasesForCalculateMean))]
    public void CalculateMean_ReturnsMean(int[] input, double expectedResult)
    {
        //Arrange
        kataSolver = new();

        //Act
        double calcuatedResult = kataSolver.CalculateMean(input);

        //Assert
        Assert.AreEqual(expectedResult, calcuatedResult);
    }

    [Test]
    [TestCaseSource(nameof(TestCasesForSumAsciiValues))]
    public void SumAsciiValues_returnsIntSum(string input, int expectedResult)
    {
        //Arrange
        kataSolver = new();

        //Act
        int calcuatedResult = kataSolver.SumAsciiValues(input);

        //Assert
        Assert.AreEqual(expectedResult, calcuatedResult);
    }

    [Test]
    [TestCaseSource(nameof(TestCasesForEvaluateLecture))]
    public void EvaluateLecture_ReturnsEvaluation(string input, string expectedResult)
    {
        //Arrange
        kataSolver = new();

        //Act
        string methodCallResult = kataSolver.EvaluateLecture(input);

        //Assert
        Assert.That(methodCallResult, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCaseSource(nameof(TestCasesForCreateCaesarCipher))]
    public void CreateCaesarCipher_ReturnsEncodedString(string input, string expectedResult)
    {
        //Arrange
        kataSolver = new();

        //Act
        string methodCallResult = kataSolver.CreateCaesarCipher(input);

        //Assert
        Assert.That(methodCallResult, Is.EqualTo(expectedResult));
    }
}
