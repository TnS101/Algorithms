using System;

namespace Interview_Prep.ROITI
{
    public class Pyramid
    {
        public void Exe(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = i; j <= i; j++)
                {
                    if (j >= n)
                    {
                        Console.WriteLine();
                        return;
                    }

                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
        }
    }
}
