namespace Interview_Prep.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayOperations
    {
        public void RotateArrayToPivot(int pivot)
        {
            int[] x = { 1, 5, 3, 6, 7, 8, 9, 11, 12 };
            var y = new List<int>(x.Skip(pivot).Take(x.Length - pivot));
            y.AddRange(x.Take(pivot));
            int[] rotatedArray = y.ToArray();

            foreach (var item in rotatedArray)
            {
                Console.WriteLine(item);
            }
        }

        public bool CheckSumFromTwoArrays(int[] arr1, int[] arr2, int target)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);

            Console.WriteLine(String.Join(", ", arr1));
            Console.WriteLine(String.Join(", ", arr2));

            int mid;
            var start = 0;
            var end = arr1.Length;

            while (start < end)
            {
                mid = (start + end) / 2;

                if (arr1[mid] + arr2[mid] < target)
                {
                    start = mid + 1;
                }
                else if (arr1[mid] + arr2[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public void SortArrayInDescendingOrder(int[] arr) 
        {
            Array.Sort(arr);
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
