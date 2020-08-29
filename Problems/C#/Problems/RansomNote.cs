using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Prep.Problems
{
    public class RansomNote
    {
        public void Exe(string[] magazine, string[] note) 
        {
            var testSet = new HashSet<string>(note);
            if (testSet.Count < note.Length)
            {
                Console.WriteLine("No");
                return;
            }

            var set = new HashSet<string>(magazine);

            for (int i = 0; i < note.Length; i++)
            {
                if (!set.Contains(note[i]))
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
