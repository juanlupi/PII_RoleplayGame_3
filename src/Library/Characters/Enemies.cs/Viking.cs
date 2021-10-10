using System.Collections.Generic;
namespace RoleplayGame
{
    public class Viking: Enemy
    {
        public Viking(string name, int vp)
            : base(name, vp)
        {
            this.AddItem(new Bow());
            this.AddItem(new Axe());
            this.AddItem(new Shield());
        }
    }
}