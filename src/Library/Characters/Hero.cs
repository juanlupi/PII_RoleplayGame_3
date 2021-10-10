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
                return this.vp;
            }
            
            set
            {
                this.vp = value;
            }
        }

        public void GetEnemyVP(Enemy enemy)
        {
            this.VP += enemy.VP;
        }

    }
}