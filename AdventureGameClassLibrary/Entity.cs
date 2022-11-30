namespace AdventureGameClassLibrary
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public Weapon Weapon { get; set; }

        public int Gold { get; set; }

        public Entity(string name, int hitpoints, Weapon weapon)
        {
            Name = name;
            Hitpoints = hitpoints;
            Weapon = weapon;
        }

        public bool IsAlive() 
        {
            if (Hitpoints > 0) return true;
            return false;
        }

        public int Attack()
        {
            if (Weapon == null) return 1;
            return RandomNumber.GetRandom(Weapon.MaxDamage);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}