namespace Interview_Prep.RhoninSoft_Prep
{
    using System.Collections.Generic;
    using System.Linq;

    public class CoffeeMaker : Machine
    {
        private int water;
        private int beans;
        private readonly int maxWater;
        private readonly int maxBeans;

        public CoffeeMaker(string name, double price, int durability, HashSet<Command> commands, int beans, int water)
            : base(name, price, durability, commands)
        {
            this.water = water;
            this.beans = beans;
            this.maxWater = water;
            this.maxBeans = beans;
        }

        public string ExecuteCommand(string commandName, int times)
        {
            var command = this.Commands.FirstOrDefault(c => c.Name == commandName);

            if (command.Materials.Count > 0)
            {
                foreach (var mat in command.Materials)
                {
                    if (mat.Key == "water")
                    {
                        if (this.water < mat.Value * times)
                        {
                            return $"Not Enough water to finish the command! ({this.water} / {mat.Value * times})";
                        }

                        this.water -= mat.Value * times;
                    }
                    else 
                    {
                        if (this.beans < mat.Value * times)
                        {
                            return $"Not Enough beans to finish the command! ({this.beans} / {mat.Value * times})";
                        }

                        this.beans -= mat.Value * times;
                    }
                }
            }

            return base.DoWork(commandName, times);
        }

        public override string GetInfo()
        {
            var result = base.GetInfo();

            result += $"\nRemaining water in Canister : {this.water} / {this.maxWater} \nRemaining beans in Canister : {this.beans} / {this.maxBeans}";

            return result;
        }
    }
}
