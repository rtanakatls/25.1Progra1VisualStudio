using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week3.Example2
{
    internal class Week3Example2Menu : Menu
    {
        public override void Execute()
        {
            Player p = new Player();

            Potion manaPotion = new Potion("Mana");
            Rock rock = new Rock("Rock");

            p.Pick(manaPotion);
        }
    }
}
