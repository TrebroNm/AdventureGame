using AdventureGameClassLibrary;

namespace AdventureGameTest
{
    public class EntityTests
    {
        Enemy enemy;
        Character character;
        [SetUp]

        public void Setup()
        {
            Weapon katana = new Weapon("Katana", 8);
            enemy = new Enemy("Monster", 25, katana);
            character = new Character("Jim", 12);
            character.Exp = 1001;
        }

        [Test]
        public void TestIsAlive()
        {
            
            Assert.AreEqual(true, enemy.IsAlive());
        }

        [Test]
        public void TestWeaponName()
        {
            Assert.AreEqual("Katana", enemy.Weapon.Name);
        }

        [Test]
        public void TestCharacterLevel()
        {
            Assert.AreEqual(2, character.Level());
        }

        [Test]
        public void TestNullWeaponAttack()
        {
            Assert.AreEqual(1, character.Attack());
        }

        [Test]
        public void TestWeaponAttack()
        {
            for (int i = 0; i < 10; i++)
            {
                if (enemy.Attack() > enemy.Weapon.MaxDamage || enemy.Attack() < 1)
                {
                    Assert.Fail("Attack damage exceeded limits!");
                }
            }
            Assert.Pass("Attack damage withing correct limits!");
        }
    }
}