namespace TDDCommunicationChallenge;

public class KataSolver
{
    public int SumMiddleNumbers(int[] numbers)
    {
        if (numbers.Length <= 1)
        {
            return 0;
        }
        int sumOfAllNumbers = numbers.Sum();
        int resultNumber = sumOfAllNumbers;
        resultNumber -= (numbers.Max() + numbers.Min());
        return resultNumber;
    }

    public double CalculateMean(int[] numbers)
    {
        int numberCount = numbers.Count();
        if (numberCount == 0)
            return 0;

        double sumOfAllNumbers = numbers.Sum();
        double mean = sumOfAllNumbers / numberCount;

        return mean;
    }
}
