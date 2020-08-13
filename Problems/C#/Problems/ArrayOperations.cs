namespace Interview_Prep.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayOperations
    {
        public void RotateArrayToPivot(int[] arr, int pivot)
        {
            int[] x = { 1, 5, 3, 6, 7, 8, 9, 11, 12 };
            var y = new List<int>(x.Skip(4).Take(x.Length - pivot));
            y.AddRange(x.Take(4));
            int[] rotatedArray = y.ToArray();

            foreach (var item in rotatedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
