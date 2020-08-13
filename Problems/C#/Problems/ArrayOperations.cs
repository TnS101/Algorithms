namespace Interview_Prep.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayOperations
    {
        public void RotateArrayToPivot(int pivot)
        {
            int[] input = { 1, 5, 3, 6, 7, 8, 9, 11, 12 };

            var tempList = new List<int>(input.Skip(pivot).Take(input.Length - pivot));

            tempList.AddRange(input.Take(pivot));

            int[] rotatedArray = tempList.ToArray();

            this.PrinArray(rotatedArray);
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

            this.PrinArray(arr);
        }

        public void ReverseAnArray(int[] arr)
        {
            Array.Reverse(arr);
            this.PrinArray(arr);
        }

        public void BubbleSort(int[] arr)
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var temp = arr[i];

                arr[i] = arr[arr.Length - i - 1];

                arr[arr.Length - i - 1] = temp;
            }

            this.PrinArray(arr);
        }

        public void SwapMinAndMaxIntegers(int[] arr)
        {
            Array.Sort(arr);

            var temp = arr[0];

            arr[0] = arr[^1];

            arr[^1] = temp;

            this.PrinArray(arr);
        }

        public bool CheckForDuplicateNumber(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    return true;
                }
            }

            return false;
        }

        public int FindMajorityElementInUnsortedArray(int[] arr)
        {
            if (arr.Any(e => arr.Count(c => c == e) > arr.Length / 2))
            {
                return arr.FirstOrDefault(e => arr.Count(c => c == e) > arr.Length / 2);
            }

            return -1;
        }

        public void MergeSort(int[] arr1, int[] arr2)
        {

        }

        public int FindMissingInteger(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] + 1 != arr[i + 1])
                {
                    return arr[i + 1] + 1;
                }

                if (arr[arr.Length - 1 - i] - 1 != arr[arr.Length - 2 - i])
                {
                    return arr[arr.Length - 1 - i] - 1;
                }
            }

            return -1;
        }

        public void MoveZeroesAtTheEnd(int[] arr) 
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var temp = arr[i];

                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            this.PrinArray(arr);
        }

        private void PrinArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
