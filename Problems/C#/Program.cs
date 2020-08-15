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

            //Console.WriteLine(new BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 8, 9, 20, 65, 80, 90, 105, 250, 260 }).Execute(260));

            Console.WriteLine(new NumericOperations().AngleBetweenClockArrows(4,20));
        }
    }

}
