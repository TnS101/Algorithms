using Interview_Prep.Problems;
using System;

namespace Interview_Prep
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new StringOperations().AreAnagrams("helo", "oleh"));
            Console.WriteLine(new StringOperations().ReverseAStringWithItteration("hello"));
        }
    }

}
