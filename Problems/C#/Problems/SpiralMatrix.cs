namespace Interview_Prep.Problems
{
    using System.Collections.Generic;

    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();
            var thickness = 0;

            if (matrix.Length == 0) return result;

            for (int j = 0; j < matrix[0].Length - thickness; j++)
            {
                result.Add(matrix[0][j]);
            }

            thickness++;

            for (int i = 1; i < matrix.Length; i++)
            {
                var row = matrix[i];

                if (i % 2 == 0)
                {
                    row = matrix[i - 1];

                    for (int j = 0; j < row.Length - thickness; j++)
                    {
                        result.Add(row[j]);
                    }
                }
                else
                {
                    var counter = i;

                    for (int j = matrix.Length - thickness; j > 0; j--)
                    {
                        result.Add(matrix[counter][row.Length - thickness]);
                        counter++;
                    }

                    for (int j = row.Length - thickness - 1; j >= 0; j--)
                    {
                        result.Add(matrix[counter - thickness][j]);
                    }
                }
            }

            return result;
        }
    }
}
