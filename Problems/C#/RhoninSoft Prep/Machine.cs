using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Interview_Prep.RhoninSoft_Prep
{
    public abstract class Machine
    {
        public Machine(string name, double price, int durability, HashSet<Command> commands)
        {
            this.Name = name;
            this.Price = price;
            this.Commands = commands;
            this.Durability = durability;
            this.MaxDurability = durability;
        }
        
        protected string Name { get; set; }

        protected double Price { get; set; }

        protected int Durability { get; set; }

        protected int MaxDurability { get; set; }

        protected HashSet<Command> Commands { get; set; }

        protected string DoWork(string commandName, int times)
        {
            var command = this.Commands.FirstOrDefault(c => c.Name == commandName);
            this.Durability -= command.DurabilityCost * times;

            if (this.Durability < 0)
            {
                var message = $"Work {commandName} could not be done! Need {this.Durability * -1} more Durability! Please repair your Machine ({this.Name})!";
                this.Durability = 0;
                return message;
            }

            return $"Work {commandName} has been done! Remaining durability on Machine : {this.Name} : {this.Durability} / ${this.MaxDurability}";
        }

        public virtual string GetInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Information about Machine with name : {this.Name}");
            sb.AppendLine($"Price : {this.Price}");
            sb.AppendLine($"Durablity : {this.Durability} / {this.MaxDurability}");

            return sb.ToString();
        }
    }
}
