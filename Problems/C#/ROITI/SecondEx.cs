namespace Interview_Prep.ROITI
{
    public class SecondEx
    {
        public double Exe(string input)
        {
            double sum = 0;

            var arr = input.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (double.TryParse(arr[i], out _))
                {
                    sum += double.Parse(arr[i]);
                }
            }

            return sum;
        }
    }
}
