namespace Interview_Prep.Problems
{
    public class SpecialStringAgain
    {
        public long Exe(string s)
        {
            long result = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                var startChar = s[i];
                int diffCharIdx = -1;

                for (int j = i + 1; j < s.Length; j++)
                {
                    var currChar = s[j];
                    if (startChar == currChar)
                    {
                        if ((diffCharIdx == -1) || (j - diffCharIdx) == (diffCharIdx - i)) //Check for duplicates
                        {
                            result++;
                        }
                    }
                    else
                    {
                        if (diffCharIdx == -1) 
                        {
                            diffCharIdx = j; //Set to the next index
                        }
                        else 
                        {
                            break; //End of string
                        }
                    }
                }
            }

            return result;
        }
    }
}
