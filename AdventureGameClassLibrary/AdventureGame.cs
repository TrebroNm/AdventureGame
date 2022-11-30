using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameClassLibrary
{
    public class AdventureGame
    {
        private Character character;
        private Enemy enemy;

        public void Play(string name)
        {
            character = AdventureGameTools.GenerateCharacter(name);

            bool run = true;
            while (run)
            {
                enemy = AdventureGameTools.GenerateEnemy("Sauron");

                AdventureGameTools.CharacterIntroduction(character);
                AdventureGameTools.EnemyIntroduction(enemy);

                Console.WriteLine("Press any key to play a round");
                Console.ReadKey();
                run = PlayRound();
            }

            AdventureGameTools.GameOver(character);
        }

        private bool PlayRound()
        {
            Attack(character, enemy);
            if (!enemy.IsAlive())
            {   
                GatherLoot();
                return true;
            }

            Attack(enemy, character);
            if (!character.IsAlive())
            {
                return false;
            }

            return PlayRound();
        }

        private void Attack(Entity attacker, Entity defender)
        {
            int attackValue = attacker.Attack();
            defender.Hitpoints -= attackValue;
            Console.WriteLine($"{attacker.Name} attacks for {attackValue} damage! {defender.Name} has {defender.Hitpoints} hp left!");
            Thread.Sleep(1000);
        }

        private void GatherLoot()
        {
            character.Gold += enemy.Gold;
            character.Exp += RandomNumber.GetRandom(500);
        }

    }
}
