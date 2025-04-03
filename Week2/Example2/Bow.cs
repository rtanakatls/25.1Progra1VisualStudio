using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week2.Example2
{
    internal class Bow : RangedWeapon
    {
        public Bow(string name, int damage, int distance, Arrow arrow): base(name,damage,distance)
        {
            ammo = arrow;
        }

    }
}
