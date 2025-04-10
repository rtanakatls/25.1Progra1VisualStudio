using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week3.Example1
{
    internal class Triangle : Shape, ICalculateArea
    {
        protected float a;
        protected float b;

        public Triangle(string name, float a, float b) : base(name)
        {
            this.a = a;
            this.b = b;
        }

        public float CalculateArea()
        {
            return a * b / 2;
        }

        public override string GetDetails()
        {
            return $"Triángulo: {name} - con base {a} y altura {b}";
        }
    }
}
