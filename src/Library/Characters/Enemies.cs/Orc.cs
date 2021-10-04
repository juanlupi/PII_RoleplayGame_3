using System.Collections.Generic;
namespace RoleplayGame
{
    public class Orc: Enemy
    {
        public Orc(string name, int vp)
            : base(name, vp)
        {
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
            this.AddItem(new Shield())
        }
    }
}