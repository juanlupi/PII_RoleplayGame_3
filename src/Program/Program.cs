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

            // Heroes
            Knight knight = new Knight("Franco");
            Archer archer = new Archer("Juan");

            //Enemies
            Orc orc1 = new Orc("Luis",2);
            Orc orc2 = new Orc("Josema",4);
            Orc orc3 = new Orc("Pedro",3);
            Orc orc4 = new Orc("Edinson",3);
            Viking viking = new Viking("Eivor",7);

            //The encounter starts
            Encounter battlefield = new Encounter();
            
            //Add enemies
            battlefield.AddEnemy(orc1);
            battlefield.AddEnemy(orc2);
            battlefield.AddEnemy(orc3);
            battlefield.AddEnemy(orc4);
            battlefield.AddEnemy(viking);
           
            //Add heroes           
            battlefield.AddHero(knight);
            battlefield.AddHero(archer);

            battlefield.StartEncounter();
        }
    }
}
