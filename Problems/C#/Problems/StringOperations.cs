namespace Interview_Prep.Problems
{
    using System.Text;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StringOperations
    {
        private readonly StringBuilder sb;
        public StringOperations()
        {
            this.sb = new StringBuilder();
        }

        public void PrintDuplicates(string input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i - 1] == input[j])
                    {
                        sb.AppendLine($"{input[j]}");
                        break;
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }

        public string RemoveDuplicates(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (sb.ToString().IndexOf(input[i]) == -1)
                {
                    sb.Append(input[i]);
                }
            }

            return sb.ToString();
        }

        public bool AreAnagrams(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                return false;
            }

            var list1 = input1.ToLower().ToCharArray();
            var list2 = input2.ToLower().ToCharArray();

            Array.Sort(list1);
            Array.Sort(list2);

            for (int i = 0; i < list1.Length; i++)
            {
                if (list1[i] != list2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public string ReverseAStringWithItteration(string input) 
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
        }
    }
}
