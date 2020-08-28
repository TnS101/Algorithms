using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Prep.Problems
{
    public class MarkAndToys
    {
        public void Exe(int money, int[] arr) 
        {
            var temp = 0;

            var result = 0;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                Console.WriteLine($"{temp} -> {arr[i]}");
                if (temp == 0)
                {
                    if (arr[i] < arr[arr.Length - i - 1])
                    {
                        temp = arr[arr.Length - i - 1];
                        if (money - arr[i] >= 0)
                        {
                            money -= arr[i];
                            result++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    if (arr[i] < temp)
                    {
                        if (money - arr[i] >= 0)
                        {
                            money -= arr[i];
                            result++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (money - temp >= 0)
                        {
                            money -= temp;
                            result++;
                        }
                        else
                        {
                            break;
                        }

                        temp = arr[i];
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
