using Interview_Prep.RhoninSoft_Prep;
using System;
using System.Collections.Generic;

namespace Interview_Prep
{
    public class Program
    {
        static void Main(string[] args)
        {
            var makeCoffeeCommand = new Command("Make Coffee", 2, new Dictionary<string, int>
            {
                ["beans"] = 2,
                ["water"] = 1
            });
            var coffeeMaker = new CoffeeMaker("Kafe", 100, 10, new HashSet<Command> { makeCoffeeCommand }, 10, 10);

            Console.WriteLine(coffeeMaker.ExecuteCommand("Make Coffee", 10));
            Console.WriteLine(coffeeMaker.GetInfo());
        }
    }

}
