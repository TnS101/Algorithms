using System;
using System.Collections.Generic;
using System.Linq;
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

            if (n == 0)
            {
                return 0;
            }

            var arr = s.ToCharArray();
            var occurence = arr.Where(c => c == 'a').Count();

            long result = 0;

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
