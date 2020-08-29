namespace Interview_Prep.Problems
{
    public class DecrpytPassword
    {
        public string Exe(string s) 
        {
            for (int i = 1; i < s.Length; i++) //> 96 Lower  < 91 Upper
            {
                if (this.IsLower(s[i - 1]) && this.IsUpper(s[i]))
                {
                    if (i + 2 < s.Length)
                    {
                        var temp = s[i - 1].ToString();
                        var temp1 = s[i].ToString();
                        s = s.Remove(i - 1, 2);
                        s = s.Insert(i - 1, temp1);
                        s = s.Insert(i, temp);
                        s = s.Insert(i + 2, "*");
                    }
                }
                else if (this.IsUpper(s[i - 1]) && this.IsLower(s[i]))
                {
                    var temp = s[i - 1].ToString();
                    var temp1 = s[i].ToString();
                    s = s.Remove(i - 1, 2);
                    s = s.Insert(i - 1, temp1);
                    s = s.Insert(i, temp);
                    s = s.Insert(i + 2, "*");
                }
                else if (s[i] > 47 && s[i] < 58)
                {
                    var temp = s[i].ToString();
                    var index = s.IndexOf(s[i]) + 2;
                    s = s.Remove(i, 1);
                    s = s.Insert(0, temp);
                    s = s.Insert(index, "0");
                    break;
                }
            }

            return s;
        }

        private bool IsUpper(char c) 
        {
            if (c > 64 && c < 91)
            {
                return true;
            }

            return false;
        }

        private bool IsLower(char c) 
        {
            if (c > 96 && c < 123)
            {
                return true;
            }

            return false;
        }
    }
}
