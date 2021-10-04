using System.Collections.Generic;
namespace RoleplayGame
{
    public class Hero: Character
    {
        private int vp = 0;

        public Hero(string name)
            : base(name)
        {
        }

        public int VP 
        {
            get 
            {
                return this.VP;
            }
            
            set
            {
                this.VP = value;
            }
        }

        public Hero(string name)
            : base(name)
        {
        }

        public GetEnemyVP(Enemy enemy)
        {
            this.VP += enemy.VP
        }

    }
}