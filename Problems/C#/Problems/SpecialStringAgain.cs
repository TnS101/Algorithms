namespace Interview_Prep.Problems
{
    using System;
    using System.Text;
    using System.Linq;

    public class SpecialStringAgain
    {
        public int Exe(string s)
        {
            var result = s.Length;

            if (s.ToCharArray().Distinct().Count() == 1)
            {
                result += s.Length / 2 + s.Length;
                return result;
            }

            var head = s[0];
            var sub = new StringBuilder();
            sub.Append(head);

            for (int i = 1; i < s.Length; i++)
            {
                if (head == s[i])
                {
                    if (sub.ToString() == head.ToString())
                    {
                        result++;
                    }
                    else
                    {
                        sub.Append(s[i]);

                        var toString = sub.ToString();

                        if (toString.SequenceEqual(toString.Reverse()))
                        {
                            result++;
                            i--;
                            sub.Clear();
                            sub.Append(s[i]);
                        }
                    }

                    head = s[i];
                }
                else
                {
                    sub.Append(s[i]);
                }
            }

            return result;
        }
    }
}
