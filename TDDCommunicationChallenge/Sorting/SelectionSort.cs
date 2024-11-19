namespace Sorting;

public class SelectionSort : ISortable
{
    public void Sort(int[] collection)
    {
        int loopingReach = 0;

        while (loopingReach <= collection.Count() - 1)
        {
            int[] collectionInRange = collection[loopingReach..];

            int smallestElement = collectionInRange.Min();
            int indexOfSmallestElement = Array.IndexOf(collection, smallestElement);

            int temp = collection[loopingReach];
            collection[loopingReach] = smallestElement;
            collection[indexOfSmallestElement] = temp;

            loopingReach++;
        }
    }
}
