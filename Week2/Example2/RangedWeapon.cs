using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week2.Example2
{
    internal abstract class RangedWeapon : Weapon
    {
        protected int distance;
        protected Ammo ammo;

        public RangedWeapon(string name, int damage, int distance) : base(name, damage)
        {
            this.distance = distance;
        }

        public override int GetDamage()
        {
            return ammo.GetDamage() + damage;
        }

    }
}
