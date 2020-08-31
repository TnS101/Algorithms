using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Prep.Problems
{
    public class MinimumSwaps
    {
        public int Exe(int[] arr) 
        {
            var result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i - 1 > 0)
                {
                    if (arr[i - 1] != i + 1 && i + 1 < arr.Length && arr[i + 1] != i + 1)
                    {
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        result++;
                    }
                    else
                    {
                        var temp = arr[i];
                        arr[temp - 1] = arr[i];
                        arr[i] = temp;
                        result++;
                    }
                }
                else
                {
                    var temp = arr[i];
                    arr[temp - 1] = arr[i];
                    arr[i] = temp;
                    result++;
                }
            }

            Console.WriteLine(String.Join("",arr));

            return result;
        }
    }
}
