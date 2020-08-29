namespace Interview_Prep.Problems
{
    using System;

    public class ArrayLeftRotation
    {
        public int[] Exe(int[] arr, int shift) 
        {
            shift %= arr.Length;
            int[] buffer = new int[shift];

            Array.Copy(arr, buffer, shift);
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);

            return arr;
        }
    }
}
