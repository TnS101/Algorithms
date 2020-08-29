namespace Interview_Prep.Problems
{
    using System.Collections.Generic;
    public class GetDuplicateNumbersInArrays
    {
        public void Exe(int[] arr1, int[] arr2)
        {
            var set = new HashSet<int>(arr1);

            for (int i = 0; i < arr2.Length; i++)
            {
                if (set.Contains(arr2[i]))
                {
                    System.Console.WriteLine($"Found a duplicate of {arr2[i]}");
                }
            }
        }
    }
}
