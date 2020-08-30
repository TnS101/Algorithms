using System;

namespace Interview_Prep.Problems
{
    public class BubbleSortCounter
    {
        public void Exe(int[] arr)
        {
            var result = 0;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] > arr[arr.Length - i - 1])
                {
                    var temp = arr[i];
                    arr[i] = arr[arr.Length - i - 1];
                    arr[arr.Length - i - 1] = temp;
                    result++;
                }
            }

            if (result == 0)
            {
                Print(result, arr);

                return;
            }

            var swapped = result * 2;

            if (arr.Length % 2 == 0)
            {
                result += swapped + arr.Length - swapped;
            }
            else
            {
                result = swapped + arr.Length - swapped;
            }


            Print(result, arr);

            return;
        }

        private void Print(int result, int[] arr) 
        {
            Console.WriteLine($"Array is sorted in {result} swaps.");
            Console.WriteLine($"First Element: {arr[0]}");
            Console.WriteLine($"Last Element: {arr[arr.Length - 1]}");
        }
    }
}
