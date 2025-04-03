using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week2.Example2
{
    internal class EnemyArcher : Enemy
    {
        protected Bow bow;

        public EnemyArcher(string name, int damage, Bow bow):base(name, damage)
        {
            this.bow = bow;
        }

        public override int GetDamage()
        {
            return bow.GetDamage() + damage;
        }

    }
}
