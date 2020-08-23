namespace Interview_Prep.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ArrayOperations
    {
        private readonly StringBuilder sb;
        public ArrayOperations()
        {
            this.sb = new StringBuilder();
        }

        public void RotateArrayToPivot(int pivot)
        {
            int[] input = { 1, 5, 3, 6, 7, 8, 9, 11, 12 };

            var tempList = new List<int>(input.Skip(pivot).Take(input.Length - pivot));

            tempList.AddRange(input.Take(pivot));

            int[] rotatedArray = tempList.ToArray();

            this.PrinArray(rotatedArray);
        }

        public void Pyramid(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
                    Console.Write(" ");
                }

                if (i > 1)
                {
                    i += 2;
                }

                for (int j = i; j <= 3 * i; j++)
                {
                    if (j >= arr.Length)
                    {
                        Console.WriteLine();
                        return;
                    }

                    Console.Write(arr[j]);
                }

                Console.WriteLine();
            }
        }

        public void PyramidWithRecursion(int[] arr)
        {
            Pattern(arr.Length - 1, arr.Length - 1, arr);
        }

        private void PrintSpace(int space) 
        {
            if (space == 0)
            {
                return;
            }

            Console.Write(" ");

            PrintSpace(space - 1);
        }

        private void PrintElement(int index, int[] arr) 
        {
            if (index == 0)
            {
                return;
            }

            Console.Write($"{arr[index]} ");
        }

        private void Pattern(int n, int num, int[] arr) 
        {
            if (n == 0)
            {
                return;
            }

            PrintSpace(n - 1);
            PrintElement(num - n + 1, arr);
            Console.WriteLine();

            Pattern(n - 1, num, arr);
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
            var index = Array.IndexOf(arr, arr.FirstOrDefault(a => a != -1));

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    arr[i] = -1;
                    i--;
                    index = Array.IndexOf(arr, arr.FirstOrDefault(a => a != -1));
                }
                else
                {
                    if (index == i)
                    {
                        Console.WriteLine($"{index} => {i}");
                        index = Array.IndexOf(arr, arr.FirstOrDefault(a => a != -1));
                    }
                    else
                    {
                        if (arr[i] == arr.FirstOrDefault(a => a != -1))
                        {
                            Console.WriteLine($"{index} => {i}");
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public int OneRepeatingNumber(int[] arr)
        {
            var sum = arr.Sum(a => a);

            return sum - arr.Length * (arr.Length - 1) / 2;
        }

        public int OneMissingNumber(int[] arr)
        {
            var sum = arr.Sum(a => a);

            return (arr.Length + 1) * (arr.Length + 2) / 2 - sum;
        }

        public int FindMajorityElementInUnsortedArray(int[] arr)
        {
            if (arr.Any(e => arr.Count(c => c == e) > arr.Length / 2))
            {
                return arr.FirstOrDefault(e => arr.Count(c => c == e) > arr.Length / 2);
            }

            return -1;
        }

        public void MergeTwoSortedArrays(int[] arr1, int[] arr2)
        {
            var result = new int[arr1.Length + arr2.Length];

            int i = 0;
            int j = 0;

            for (int k = 0; k < result.Length; k++)
            {
                if (i == arr1.Length)
                {
                    result[k] = arr2[j];
                    j++;
                }
                else if (j == arr2.Length)
                {
                    result[k] = arr1[i];
                    i++;
                }
                else if (arr1[i] <= arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                }
                else
                {
                    result[k] = arr2[j];
                    j++;
                }
            }

            this.PrinArray(result);
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

        public bool FindPairOfX(int[] arr, int x)
        {
            var right = arr[^1];
            var left = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (left + right < x)
                {
                    if (left < right)
                    {
                        left = arr[i + 1];
                    }
                    else
                    {
                        right = arr[arr.Length - i - 1];
                    }
                }
                else if (left + right > x)
                {
                    if (left < right)
                    {
                        right = arr[arr.Length - i - 1];
                    }
                    else
                    {
                        left = arr[i + 1];
                    }
                }
                else
                {
                    Console.WriteLine($"{left} + {right} = {x}");
                    return true;
                }
            }

            return false;
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

        public void PrinArray(int[] arr)
        {
            sb.Append("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                this.sb.Append($"{arr[i]}, ");
            }

            sb.Append(" ]");

            Console.WriteLine(this.sb.ToString());
        }
    }
}
