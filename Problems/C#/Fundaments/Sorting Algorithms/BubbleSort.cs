namespace Interview_Prep.Fundaments.Sorting_Algorithms
{
    using System;

    public class BubbleSort
    {
        public BubbleSort(int[] arr, int left, int right)
        {
            Array.Sort(arr);

            for (int i = left; i < right / 2; i++)
            {
                var temp = arr[i];

                arr[i] = arr[right - i - 1];

                arr[right - i - 1] = temp;
            }
        }
    }
}
