using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameClassLibrary
{
    public class Weapon
    {
        public string Name { get; set; }
        public int MaxDamage { get; set; }

        public Weapon(string name, int maxDamage)
        {
            Name = name;
            MaxDamage = maxDamage;
        }
    }
}
