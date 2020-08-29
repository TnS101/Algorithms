namespace Interview_Prep.Problems
{
    using System;

    public class MarkAndToys
    {
        public int Exe(int[] arr, int money) 
        {
            var result = 0;

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (money - arr[i] > 0)
                {
                    money -= arr[i];
                    result++;
                }
            }

            return result;
        }
    }
}
