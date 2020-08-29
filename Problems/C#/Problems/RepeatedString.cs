using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Prep.Problems
{
    public class RepeatedString
    {
        public long Exe(string s, long n) 
        {
            if (s.Length == 1)
            {
                return n;
            }

            var occurence = 0;

            var result = 0;
            var arr = s.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'a')
                {
                    occurence++;
                }
            }

            if (n % s.Length == 0)
            {
                result += (int)((occurence * n) / s.Length);
            }
            else
            {
                var remainder = n % s.Length;
                var whole = (n - remainder) / s.Length;

                result += (int)whole * occurence;

                var length = (int)remainder;


                for (int i = 0; i < length; i++)
                {
                    if (arr[i] == 'a')
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
