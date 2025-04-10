using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1251.Week3.Example1
{
    internal class Week3Example1Menu : Menu
    {
        public override void Execute()
        {
            List<Shape> shapes = new List<Shape>();
            List<ICalculateArea> interfaces = new List<ICalculateArea>();

            Triangle t1 = new Triangle("T1", 10, 20);
            Triangle t2 = new Triangle("T2", 20, 30);
            Rectangle r1 = new Rectangle("R1", 5, 10);
            Rectangle r2 = new Rectangle("R2", 10, 20);

            shapes.Add(t1);
            shapes.Add(t2);
            shapes.Add(r1);
            shapes.Add(r2);

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.GetDetails());
            }

            interfaces.Add(t1);
            interfaces.Add(t2);
            interfaces.Add(r1);
            interfaces.Add(r2);

            foreach(ICalculateArea area in interfaces)
            {
                Console.WriteLine($"El área es: {area.CalculateArea()}");
            }


        }
    }
}
