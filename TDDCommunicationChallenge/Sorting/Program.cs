namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubble = new();
            int[] numbers = new int[] { 6, 5, 3, 7, 2 };
            bubble.Sort(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
