namespace Interview_Prep.Fundaments
{
    using System;

    public class NumericOperations
    {
        public void SwapNumberValues(int num1, int num2)
        {
            num1 = num2 ^ num1;
            num2 ^= num1;
            num1 ^= num2;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        public int SumOfDigits(int num)
        {
            if (num != 0)
            {
                return (num % 10 + this.SumOfDigits(num / 10));
            }
            else
            {
                return 0;
            }
        }

        public double AngleBetweenClockArrows(int hour, int minutes) 
        {
            if (hour > 12)
            {
                hour -= 12;
            }

            return Math.Abs((hour * 30) - (minutes * 6));
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

        public bool IsPalindrome(int num)
        {
            var reverse = 0;
            var initValue = num;

            while (num > 0)
            {
                var remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }

            Console.WriteLine(initValue);
            Console.WriteLine(reverse);

            return initValue == reverse ? true : false;
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
