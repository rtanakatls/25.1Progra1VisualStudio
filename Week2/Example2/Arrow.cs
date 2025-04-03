using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week2.Example2
{
    internal class Arrow : Ammo
    {
        protected int speed;

        public Arrow(string name, int damage, int speed) : base(name, damage)
        {
            this.speed = speed;
        }
    }
}
