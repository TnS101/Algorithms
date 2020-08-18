namespace Interview_Prep.Fundaments
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

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

        public void ReverseEveryKNode(LinkedList<int> list, int k)
        {
            var start = 0;
            var end = k;

            for (int i = 0; i < list.Count; i++)
            {
                if (i % k == 0)
                {
                    if (i + k >= list.Count)
                    {
                        break;
                    }

                    for (int j = start; j < end; j++)
                    {
                        var left = list.Find(list.ElementAt(j));
                        var right = list.Find(list.ElementAt(end - j - 1));
                        var temp = left.Value;
                        Console.WriteLine($"Swap {left.Value} and {right.Value}!");

                        left.Value = right.Value;
                        right.Value = temp;
                    }
                    start += k;
                    end += k;
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void RemoveAndRetainNodesFromLinkedList(LinkedList<int> list, int m, int n)
        {
            var counter = m;

            for (int i = 0; i < list.Count; i++)
            {
                if (counter == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i + j <= list.Count)
                        {
                            list.Remove(list.ElementAt(i));
                        }
                    }
                    counter = m;
                }

                counter--;
            }

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
