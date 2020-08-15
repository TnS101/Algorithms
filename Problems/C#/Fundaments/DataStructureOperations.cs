namespace Interview_Prep.Fundaments
{
    using System.Collections.Generic;
    using System;

    public class DataStructureOperations
    {
        public void ReverseALinkedList(LinkedList<int> list)
        {
            var result = new LinkedList<int>();

            var start = list.Last;

            while (start != null)
            {
                result.AddLast(start.Value);
                start = start.Previous;
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
