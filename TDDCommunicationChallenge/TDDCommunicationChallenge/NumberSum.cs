namespace TDDCommunicationChallenge
{
    public class NumberSum
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

    }
}
