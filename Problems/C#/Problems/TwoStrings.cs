using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Prep.Problems
{
    public class TwoStrings
    {
        public string Exe(string s1, string s2) 
        {
            var set = new HashSet<char>(s1);

            for (int i = 0; i < s2.Length; i++)
            {
                if (set.Contains(s2[i]))
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }
}
