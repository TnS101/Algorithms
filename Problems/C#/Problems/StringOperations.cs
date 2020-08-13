namespace Interview_Prep.Problems
{
    using System.Text;
    using System;

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
    }
}
