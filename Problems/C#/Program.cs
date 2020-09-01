using System;

namespace Interview_Prep
{
    public class Program
    {
        static void Main(string[] args)
        {
            var grades = new int[] { 73, 67, 38, 33 };


            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    var rounded = grades[i] % 5 + grades[i];
                    if (rounded - grades[i] < 3)
                    {
                        grades[i] = rounded - 3;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", grades));
        }
    }

}
