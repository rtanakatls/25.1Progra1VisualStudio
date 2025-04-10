﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week3.Example1
{
    internal abstract class Shape
    {
        protected string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract string GetDetails();
    }
}
