namespace Interview_Prep
{
    using Interview_Prep.Problems;
    using System;
    using System.Diagnostics;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();

            var arr1 = new int[10000];
            var arr2 = new int[10000];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = new Random(i + 89890).Next(0, 1001);
                arr2[i] = new Random(i + 500).Next(0, 1001);
            }

            Array.Sort(arr1);
            Array.Sort(arr2);

            sw.Start();
            new ArrayOperations().MergeTwoSortedArrays(arr1, arr2);
            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }

}
