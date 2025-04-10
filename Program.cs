using Progra1251.Week1;
using Progra1251.Week2.Example1;
using Progra1251.Week2.Example2;
using Progra1251.Week3;
using Progra1251.Week3.Example2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Week3Example2Menu();
            menu.Execute();
        }
    }
}
