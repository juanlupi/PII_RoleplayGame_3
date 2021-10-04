using System.Collections.Generic;
namespace RoleplayGame
{
    public class Viking: Enemy
    {
        public Orc(string name, int vp)
            : base(name, vp)
        {
            this.AddItem(new Bow());
            this.AddItem(new Axe());
            this.AddItem(new Shield())
            this.AddItem(new Helmet())
        }
    }
}