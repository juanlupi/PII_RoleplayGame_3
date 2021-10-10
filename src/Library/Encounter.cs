using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Encounter
    {
        private List<Hero> heroes = new List<Hero>();
        private List<Enemy> enemies = new List<Enemy>();

        public int EnemiesRemaining 
        {
            get
            {
                return this.enemies.Count;
            }
        }

        public int HeroesRemmaining 
        {
            get
            {
                return this.heroes.Count;
            }
        }

        public void AddHero(Hero hero)
        {
            this.heroes.Add(hero);
        }

        public void AddEnemy(Enemy enemy)
        {
            this.enemies.Add(enemy);
        }

        private void HeroAttack()
        {
            foreach (Hero hero in this.heroes)
            {
                foreach (Enemy enemy in this.enemies)
                {
                    if (enemy.Health > 0)
                    {
                        enemy.ReceiveAttack(hero.AttackValue);
                        Console.WriteLine($"{hero.Name} attacked {enemy.Name} with {hero.AttackValue} damage");

                        if (enemy.Health <= 0)
                        {
                            Console.WriteLine($"{enemy.Name} died");
                            hero.GetEnemyVP(enemy);
                        }
                    }
                }
            }
        }

        private void EnemyAttack()
        {
            int cont = 0;
            foreach (Enemy enemy in this.enemies)
            {
                if (this.heroes.Count - 1 < cont)
                {
                    cont = 0;  
                }
                this.heroes[cont].ReceiveAttack(enemy.AttackValue);  
                Console.WriteLine($"{enemy.Name} attacked {this.heroes[cont].Name} with {enemy.AttackValue} damage");
                cont++;
            }
        }
        
        private void CureHeroes()
        {
            foreach (Hero hero in this.heroes)
            {
                if (hero.VP >= 5)
                {
                    hero.Cure();
                    Console.WriteLine($"{hero.Name} has been cured");
                }
            }
        }

        private void RemoveDeadEnemies()
        {
            this.enemies.RemoveAll((enemy) => enemy.Health <= 0);
        }

        
        private void RemoveDeadHeroes()
        {
            this.heroes.RemoveAll((hero) => hero.Health <= 0);
        }

        private void Winner()
        {
            if (this.heroes.Count > 0)
            {
                Console.WriteLine("Heroes won!!");
            }
            else
            {
                Console.WriteLine("Enemies won!!");
            }
        }

        //Encounter
        public void StartEncounter()
        {
            if (this.heroes.Count <= 0 || this.enemies.Count <= 0 )
            {
                Console.WriteLine("No hay peronajes suficientes para comenzar la batalla");
            }
            else
            {
                while (this.heroes.Count > 0 && this.enemies.Count > 0)
                {
                    EnemyAttack();
                    RemoveDeadHeroes();
                    HeroAttack();
                    RemoveDeadEnemies();
                    CureHeroes();
                }
                Winner();
            }
        }
    }
}