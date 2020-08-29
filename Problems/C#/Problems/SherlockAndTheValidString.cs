using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview_Prep.Problems
{
    public class SherlockAndTheValidString
    {
        public string Exe(string s)
        {
            var arr = s.ToCharArray();

            var dict = new Dictionary<char, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            int[] values = dict.OrderByDescending(c => c.Value).Select(c => c.Value).ToArray();

            var temp = values[0];
            var counter = 0;

            for (int i = 1; i < values.Length; i++)
            {
                if (values[0] != values[i])
                {
                    temp = values[i];
                }
                else
                {
                    counter++;
                }

                if (i + 1 < values.Length)
                {
                    if (temp == values[i + 1] && counter > 0)
                    {
                        return "NO";
                    }

                    if (temp != values[i + 1] && temp - counter >= values[i + 1])
                    {
                        return "NO";
                    }
                }

            }

            return "YES";
        }
    }
}
