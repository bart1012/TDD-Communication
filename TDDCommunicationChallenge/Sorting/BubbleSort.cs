namespace Sorting
{
    public class BubbleSort : ISortable
    {
        public void Sort(int[] collection)
        {
            //5,2,4,6 - 2,4,5,6 - 5,4,3,2,1 
            int loopingReach = collection.Count() - 1;

            while (loopingReach >= 0)
            {
                for (int i = 0; i < loopingReach; i++)
                {
                    int temp = 0;

                    if (collection[i] > collection[i + 1])
                    {
                        temp = collection[i];
                        collection[i] = collection[i + 1];
                        collection[i + 1] = temp;
                    }
                }

                loopingReach--;
            }



        }
    }
}
