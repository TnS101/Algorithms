namespace Interview_Prep.Problems
{
    using System;

    public class MakeAnagrams
    {
        public int Exe(string a, string b)
        {
            var set = a.ToCharArray();
            var diff = 0;
            var arr = b.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(set, arr[i]) == -1)
                {
                    diff++;
                }

            }

            return diff + b.Length - a.Length;
        }
    }
}
