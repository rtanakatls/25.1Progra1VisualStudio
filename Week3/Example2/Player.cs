using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week3.Example2
{
    internal class Player
    {
        private List<Object> objects;

        public Player()
        {
            objects = new List<Object>();
        }

        public void Pick(IPickable obj)
        {
            obj.Pick();
            objects.Add((Object)obj);
        }


    }
}
