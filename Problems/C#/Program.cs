using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview_Prep
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<int>() { 4, 6, 5, 3, 3, 1 };
            arr = arr.OrderBy(i => i).ToList();

            var result = 0;
            var temp = -1;

            for (int i = 1; i < arr.Count; i++)
            {
                var diff = Math.Abs(arr[i - 1] - arr[i]);
                if (temp == -1)
                {
                    if (diff <= 1)
                    {
                        result++;
                    }
                    else if (diff > 1 && result > 0)
                    {
                        temp = 0;
                    }
                }
                else
                {
                    if (diff <= 1)
                    {
                        temp++;
                    }
                    else
                    {
                        if (temp > result)
                        {
                            result = temp;
                        }

                        temp = -1;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }

}
