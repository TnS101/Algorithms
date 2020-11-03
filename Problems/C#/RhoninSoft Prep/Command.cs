using System.Collections.Generic;

namespace Interview_Prep.RhoninSoft_Prep
{
    public class Command
    {
        public Command(string name, int durabilityCost, Dictionary<string, int> materials)
        {
            this.Name = name;
            this.DurabilityCost = durabilityCost;
            this.Materials = materials;
        }

        public string Name { get; set; }

        public int DurabilityCost { get; set; }

        public Dictionary<string, int> Materials { get; set; }
    }
}
