namespace Interview_Prep.Problems
{
    public class AlternatingCharacters
    {
        public int Exe(string s) 
        {
            var result = 0;

            var arr = s.ToCharArray();
            var temp = char.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length)
                {
                    if (temp == char.MinValue)
                    {
                        if (arr[i] == arr[i + 1])
                        {
                            result++;
                            temp = arr[i];
                        }
                    }
                    else
                    {
                        if (temp == arr[i + 1])
                        {
                            result++;
                        }
                        else
                        {
                            temp = char.MinValue;
                        }
                    }
                }
            }

            return result;
        }
    }
}
