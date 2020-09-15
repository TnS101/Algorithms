using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview_Prep
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 4, 5, 3, 8, -3, -1 };
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var num = Math.Abs(arr[i]);

                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, i);
                }
                else
                {
                    dict[num] += arr.Length;
                }
            }

            foreach (var item in dict.Where(n => n.Value >= arr.Length).OrderBy(n => n.Value))
            {
                Console.WriteLine($"{item.Key * -1} -> {item.Key}");
            }
        }
    }

}
