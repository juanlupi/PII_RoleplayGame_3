using NUnit.Framework;

namespace RoleplayGame
{
    public class Tests
    {
        [Test]
        public void TestAttack()
        {
            Dwarf Dwarf = new Dwarf("Dwarf");
            Knight Knight = new Knight("Knight");

            Knight.ReceiveAttack(Dwarf.AttackValue);

            int expected = 100;
            Assert.AreEqual(expected, Knight.Health);
        }

        [Test]
        public void TestEncounter()
        {
            Knight knight = new Knight("Franco");
            Archer archer = new Archer("Juan");

            Orc orc1 = new Orc("Luis",2);
            Orc orc2 = new Orc("Josema",4);
            Orc orc3 = new Orc("Pedro",3);
            Orc orc4 = new Orc("Edinson",3);
            Viking viking = new Viking("Eivor",7);

            Encounter battlefield = new Encounter();
            
            battlefield.AddEnemy(orc1);
            battlefield.AddEnemy(orc2);
            battlefield.AddEnemy(orc3);
            battlefield.AddEnemy(orc4);
            battlefield.AddEnemy(viking);
                     
            battlefield.AddHero(knight);
            battlefield.AddHero(archer);

            battlefield.StartEncounter();
            
            int expected = 0;
            Assert.AreEqual(expected, battlefield.EnemiesRemaining);
        }

        [Test]
        public void TestSpellBook()
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            int expected = 2;
            Assert.AreEqual(expected, book.Spells);
        }
    }
}