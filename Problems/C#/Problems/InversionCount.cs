namespace Interview_Prep.Problems
{
    using System;

    public class InversionCount
    {
        public void Exe(int[] arr, int left, int right) 
        {
            long result = 0;
            if (left < right)
            {
                int middle = (left + right) / 2;

                this.Exe(arr, left, middle);
                this.Exe(arr, middle + 1, right);

                result += Merge(arr, left, right, middle);
            }

            Console.WriteLine(result);
        }

        private long Merge(int[] arr, int left, int right, int mid)
        {
            var result = 0;

            var leftLength = mid - left + 1;
            var rightLength = right - mid;

            var leftArr = new int[leftLength];
            var rightArr = new int[rightLength];

            Array.Copy(arr, left, leftArr, 0, leftLength);
            Array.Copy(arr, mid + 1, rightArr, 0, rightLength);

            int i = 0;
            int j = 0;

            for (int k = left; k <= right; k++)
            {
                if (i == leftLength)
                {
                    arr[k] = rightArr[j];
                    j++;
                    result++;
                }
                else if (j == rightLength)
                {
                    arr[k] = leftArr[i];
                    i++;
                    result++;
                }
                else if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                    result++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                    result++;
                }
            }

            return result;
        }
    }
}
