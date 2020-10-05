using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Prep
{
    public class Program
    {
        static void Main(string[] args)
        {
            Res();
        }

        static string Res()
        {
            int input = 20;

            var counter = 90;

            var result = new Stack<char>();

            while (true)
            {
                var curr = counter - 64;
                var charIndex = curr * ((curr - 1) * 3 + 3) + (curr - 1) * 3 + 3;
                var currSubstr = 0;

                if (charIndex == 0)
                {
                    Console.WriteLine(string.Join("", result));
                    return string.Join("", result);
                }

                Console.WriteLine(charIndex);
                Console.WriteLine((char)(counter));

                if (input > charIndex)
                {
                    if (counter == 64)
                    {
                        currSubstr = 1;
                        result.Push('A');
                    }
                    else
                    {
                        currSubstr = charIndex;
                        result.Push((char)counter);
                    }

                    input -= currSubstr;

                    if (input <= currSubstr)
                    {
                        counter--;
                    }
                }
                else
                {
                    counter--;
                }
            }
        }
    }

}
