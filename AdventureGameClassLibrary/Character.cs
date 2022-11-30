using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameClassLibrary
{
    public class Character : Entity
    {
        public CharacterTypes Type { get; set; }
        public int Exp { get; set; }

        public int Level()
        {
            return Exp/1000+1;
        }

        public Character(string name = "unnamed", int hitpoints = 20, Weapon weapon = null) : base(name, hitpoints, weapon) { }
    }

    public enum CharacterTypes
    {
        Warrior, Wizzard, Thief
    }
}
