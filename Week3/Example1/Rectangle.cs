using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week3.Example1
{
    internal class Rectangle : Shape, ICalculateArea
    {
        protected float a;
        protected float b;
        public Rectangle(string name, float a, float b) : base(name)
        {
            this.a = a;
            this.b = b;
        }

        public float CalculateArea()
        {
            return a * b;
        }

        public override string GetDetails()
        {
            return $"Rectángulo: {name} con base {a} y altura {b}";
        }
    }
}
