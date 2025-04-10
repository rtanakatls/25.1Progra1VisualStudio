using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week3.Example2
{
    internal class Potion : Object, IPickable
    {
        public Potion(string name) : base(name)
        {
        }

        public void Pick()
        {
            Console.WriteLine("Recogiste una poción");
        }
    }
}
