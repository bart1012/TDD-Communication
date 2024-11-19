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

    public string HuntingCheese(string map, int catSpeed, int mouseSpeed)
    {
        //"---K-----M---C--", 6, 0  // should return "No cheese"
        //"---K-----M---C--", 0, 6  // should return "Cheese"
        //"---K-----M---C--", 1, 1  // should return "Cheese"
        //"---K-----M---C--", 3, 1 // should return "No cheese"
        //"---K---M---C--", 2, 1  // should return "Cheese party!"

        int indexOfCheese = map.IndexOf('C');

        int indexOfMouse = map.IndexOf('M');
        int indexOfCat = map.IndexOf('K');

        int distanceMouseFromCheese = indexOfCheese - indexOfMouse;
        int distanceCatFromCheese = indexOfCheese - indexOfCat;

        // Avoids having to put in an arbitrary, large limit for 'i' in the for loop
        int maxTurnsFromMouseToCheese = 0;
        if (mouseSpeed > 0)
            maxTurnsFromMouseToCheese = (int)(Math.Ceiling((double)distanceMouseFromCheese / mouseSpeed));

        int maxTurnsFromCatToCheese = 0;
        if (catSpeed > 0)
            maxTurnsFromCatToCheese = (int)(Math.Ceiling((double)distanceCatFromCheese / catSpeed));

        int maxTurnsRequired = Math.Max(maxTurnsFromMouseToCheese, maxTurnsFromCatToCheese);

        string returnString = "";
        for (int i = 0; i < maxTurnsRequired; i++)
        {
            distanceMouseFromCheese -= mouseSpeed;
            distanceCatFromCheese -= catSpeed;

            if (distanceMouseFromCheese <= 0 && distanceCatFromCheese <= 0)
            {
                returnString = "Cheese party!";
                break;
            }
            
            if (distanceMouseFromCheese <= 0 && distanceCatFromCheese > 0)
            {
                returnString = "Cheese";
                break;
            }

            if (distanceMouseFromCheese > 0 && distanceCatFromCheese <= distanceMouseFromCheese)
            {
                returnString = "No cheese";
                break;
            }
        }

        return returnString;
    }
}
