using System.Text;

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

    public int SumAsciiValues(string text)
    {
        if (text is null) return 0;

        int sumAsciiValue = 0;

        foreach (char letter in text)
        {
            if (char.IsLetterOrDigit(letter))
            {
                sumAsciiValue += letter;
            }
        }

        return sumAsciiValue;
    }

    public string CreateCaesarCipher(string text)
    {
        StringBuilder stringBuilder = new();
        string alphabet;


        foreach (char letter in text)
        {
            if (char.IsLetter(letter))
            {
                if (char.IsLower(letter))
                {
                    alphabet = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
                }
                else
                {
                    alphabet = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz".ToUpper();
                }
                int index = alphabet.IndexOf(letter);
                stringBuilder.Append(alphabet[index + 13]);
            }
            else
            {
                stringBuilder.Append(letter);
            }
        }

        return stringBuilder.ToString();
    }

    public string EvaluateLecture(string input)
    {
        if (input is null)
            return "NEUTRAL";

        string inputWithoutDoubles = input.Replace("LL", "").Replace("DD", "");

        int likeCounter = 0;
        int dislikeCounter = 0;

        foreach (char letter in inputWithoutDoubles)
        {
            if (letter == 'L')
            {
                likeCounter++;
            }
            else if (letter == 'D')
            {
                dislikeCounter++;
            }
        }

        int likesMinusDislikes = likeCounter - dislikeCounter;

        string returnString = (likesMinusDislikes) switch
        {
            (> 0) => "LIKE",
            (< 0) => "DISLIKE",
            _ => "NEUTRAL"
        };

        return returnString;
    }
}
