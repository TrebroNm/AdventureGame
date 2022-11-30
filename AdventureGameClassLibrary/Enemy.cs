namespace AdventureGameClassLibrary
{
    public class Enemy : Entity
    {
        //public EnemyTypes Type { get; set; }
        public int MaxGold { get; set; }

        public Enemy(string name = "unnamed", int hitpoints = 1, Weapon weapon = null, int maxGold = 25) : base(name, hitpoints, weapon) {
            MaxGold = maxGold;
            Gold = RandomNumber.GetRandom(maxGold);
            
        }
    }

    enum EnemyTypes
    {
        Orc, Ogre, Goblin, Troll
    }
}
