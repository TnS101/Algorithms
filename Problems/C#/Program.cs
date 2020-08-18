namespace Interview_Prep
{
    using Interview_Prep.Fundaments;
    using Interview_Prep.Fundaments.SearchingAlgorithms;
    using Interview_Prep.Problems;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataStructureOperations();

            //Console.WriteLine(new ArrayOperations().CheckForDuplicateNumber(new int[] { 5, 8, 9, 0, 3, 4, 11, 2, 1, 3 }));

            Console.WriteLine(new ArrayOperations().FindPairOfX(new int[] { 8, 2, 5, 4, 41, 6, 17, 8, 59, 10, 15, 63, 1, 3 }, 23));
        }
    }

}
