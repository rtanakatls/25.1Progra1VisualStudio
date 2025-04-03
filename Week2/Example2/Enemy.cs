using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week2.Example2
{
    internal abstract class Enemy
    {
        protected string name;
        protected int damage;

        public Enemy(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public abstract int GetDamage();
    }
}
