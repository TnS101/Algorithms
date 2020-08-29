namespace Interview_Prep.Problems
{
    public class JumpingOnClouds
    {
        public int Exe(int n, int[] arr)
        {
            var result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length && i + 2 < arr.Length)
                {
                    if (arr[i + 2] == 0 && i + 4 < arr.Length && arr[i + 4] == 0)
                    {
                        result++;
                        i++;
                        continue;
                    }

                    if (arr[i + 1] == 0)
                    {
                        result++;
                        continue;
                    }
                }
                else
                {
                    break;
                }

                if (arr[i] == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
