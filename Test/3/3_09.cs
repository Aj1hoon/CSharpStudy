using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형 그리기...");
        }
    }

    class Cricle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원 그리기...");
        }
    }

    internal class _3_09
    {
        static void Main(string[] args)
        {
            _3_09 instance = new _3_09();

            Cricle circle = new Circle();
            Triangle triangle = new Triangle();

            instance.Draw(circle);
            instance.Draw(triangle);
        }

        public void Draw(Shape shape)
        {
            shape.Draw();
        }
    }

    internal class Circle : Cricle
    {
    }
}
