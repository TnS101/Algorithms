namespace Interview_Prep.Problems
{
    using System;

    public class HourGlassSum
    {
        public int Exe(int[][] arr) 
        {
            var result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var row = arr[i];

                for (int j = 1; j < row.Length; j++)
                {
                    if (j + 1 < row.Length && i + 2 < arr.Length)
                    {
                        var head = row[j - 1] + row[j] + row[j + 1];
                        var body = arr[i + 1][j];
                        var feet = arr[i + 2][j - 1] + arr[i + 2][j] + arr[i + 2][j + 1];

                        var tempResult = head + body + feet;

                        Console.WriteLine($"\n{row[j - 1]}*{row[j]}*{row[j + 1]}");
                        Console.WriteLine($" *{arr[i + 1][j]}*");
                        Console.WriteLine($"{arr[i + 2][j - 1]}*{arr[i + 2][j]}*{arr[i + 2][j + 1]}");

                        if (tempResult > result)
                        {
                            result = tempResult;
                        }
                    }
                }
            }

            return result;
        }
    }
}
