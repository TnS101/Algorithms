namespace Interview_Prep.Fundaments
{
    using System;

    public class NumericOperations
    {
        public void SwapNumberValues(int num1, int num2) 
        {
            num1 = num2 ^ num1;
            num2 = num2 ^ num1;
            num1 = num1 ^ num2;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        public int FindGCD(int num1, int num2) 
        {
            if (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                {
                    num1 %= num2;
                }
                else
                {
                    num2 %= num1;
                }
            }

            return num1 | num2;
        }

        public bool IsPrime(int num) 
        {
            if (num <= 1)
            {
                return false;
            }

            var factorCount = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    factorCount++;
                }
            }

            return factorCount > 2 ? false : true;
        }

        public bool IsArmstrongNumber(int num) 
        {
            double sum = 0;
            var asString = num.ToString().ToCharArray();

            for (int i = 0; i < asString.Length; i++)
            {
                sum += Math.Pow(int.Parse(asString[i].ToString()), asString.Length);
            }

            Console.WriteLine(sum);
            Console.WriteLine(num);

            if (sum == num)
            {
                return true;
            }

            return false;
        }

        public double GetRemainder(int num1, int num2) 
        {
            return num1 % num2;
        }

        public bool IsNumberDivisibleByTwo(int num) 
        {
            return num % 2 == 0;
        }
    }
}
