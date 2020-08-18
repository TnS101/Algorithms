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

            var list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.AddLast(8);

            ds.ReverseEveryKNode(list, 3);
        }
    }

}
