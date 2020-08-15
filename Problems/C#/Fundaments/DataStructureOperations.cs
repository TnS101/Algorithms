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

            list = result;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void ReverseStack(Stack<int> stack) 
        {
            var result = new Stack<int>();

            while (stack.Count > 0)
            {
                result.Push(stack.Pop());
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
