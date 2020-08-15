namespace Interview_Prep.Fundaments.Sorting_Algorithms
{
    using System;

    public class MergeSort
    {
        public void Execute(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                this.Execute(arr, left, middle);
                this.Execute(arr, middle + 1, right);

                this.Merge(arr, left, middle, right);
            }
        }

        private void Merge(int[] arr, int left, int middle, int right)
        {
            var leftLength = middle - left + 1;
            var rightLength = right - middle;

            int[] leftArr = new int[leftLength];
            int[] rightArr = new int[rightLength];

            Array.Copy(arr, left, leftArr, 0, leftLength);
            Array.Copy(arr, middle + 1, rightArr, 0, rightLength);

            int i = 0;
            int j = 0;

            for (int k = left; k <= right; k++)
            {
                if (i == leftLength)
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                else if (j == rightLength)
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
            }
        }
    }
}
