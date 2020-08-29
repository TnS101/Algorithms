namespace Interview_Prep.Problems
{
    using System;

    public class SockMerchant
    {
        public int Exe(int n, int[] arr) 
        {
            Array.Sort(arr);

            var result = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    result++;
                    i++;
                }
            }

            return result;
        }
    }
}
