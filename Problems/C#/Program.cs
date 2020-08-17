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

            new NumericOperations().GetSubsequenceWithLargestValue(new int[] { 1, 2, -5, 6, -1, 4, -2, 3, -40, -2, 3, 10, 12, 18, 30, -10, 55 });
        }
    }

}
