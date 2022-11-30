using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameClassLibrary
{
    public class AdventureGameTools
    {
        private static Weapon GenerateWeapon()
        {
            string name = "Sword";
            int maxDamage = RandomNumber.GetRandom(6);
            return new Weapon(name, maxDamage);
        }

        public static Character GenerateCharacter(string name)
        {
            return new Character(name, RandomNumber.GetRandom(12), GenerateWeapon());
        }

        public static Enemy GenerateEnemy(string name)
        {
            return new Enemy(name, RandomNumber.GetRandom(10), GenerateWeapon());
        }

        public static void CharacterIntroduction(Character character)
        {
            Console.WriteLine ($"Your character introduces himself:" +
                   $"I am a level {character.Level()} WIZZARD. My name is {character.Name}. " +
                   $"\nI have {character.Hitpoints} hp, {character.Gold} gold,{character.Exp} xp and I am equipped with a {character.Weapon.Name}!\n");

        }

        public static void EnemyIntroduction(Enemy enemy)
        {
            Console.WriteLine ($"The following monster steps forward and introduces itself:" +
                    $"I am a OGRE. My name is {enemy.Name}. I have {enemy.Hitpoints} hp and a {enemy.Weapon.Name}!\n");
        }

        public static void GameOver(Character character)
        {
            Console.WriteLine($"GAME OVER!\n" +
                              $"{character.Name} has been slained!\n" +
                              $"Final level = {character.Level()}, gold = {character.Gold}\n" +
                              $"Thank you for playing!");
        }
    }
}
