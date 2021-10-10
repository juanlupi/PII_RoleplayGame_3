using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);
            Dwarf gimli = new Dwarf("Gimli");
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
        }
    }
}
