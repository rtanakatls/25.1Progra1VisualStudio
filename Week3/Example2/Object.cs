using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week3.Example2
{
    internal class Object
    {
        protected string name;

        public string Name
        {
            get { return name; }
        }

        public Object(string name)
        {
            this.name = name;
        }
    }
}
