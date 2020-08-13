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

        public int NumberOfWords(string input)
        {
            return input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public char HighestOccuredCharacter(string input)
        {
            var count = 0;
            var dict = new Dictionary<char, int>();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == input[i])
                {
                    count++;
                }
                else
                {
                    dict.Add(input[i - 1], count);
                    count = 0;
                }
            }

            return dict.OrderByDescending(e => e.Value).FirstOrDefault().Key;
        }

        public bool IsFromUniqueCharacters(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public string ReplaceAllSpacesInAString(string input, string key)
        {
            return String.Join(key, input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        public void FindAllSubstringsInAString(string value) 
        {
            for (int i = 1; i < value.Length; i++)
            {
                for (int j = 0; j <= value.Length - i; j++)
                {
                    string substring = value.Substring(j, i);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
