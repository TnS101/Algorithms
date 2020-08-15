namespace Interview_Prep
{
    using Interview_Prep.Fundaments;
    using Interview_Prep.Problems;
    using System;
    using System.Diagnostics;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            var numeric = new NumericOperations();

            Console.WriteLine(numeric.IsPrime(2));

        }
    }

}
