namespace Interview_Prep.Problems
{
    public class CountingValleys
    {
        public int Exe(int n, string s)
        {
            var result = 0;
            var counter = 0;
            var arr = s.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (s[i] == 'U')
                {
                    counter++;
                }
                else if (s[i] == 'D')
                {
                    counter--;
                }

                if (counter == 0)
                {
                    if (s[i] != 'D')
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
