using System;
using System.Linq;

namespace Program
{
    //抽象
    public abstract class Shape
    {
        protected double ShapeArea;
        public abstract void Create();

        public void ShowArea()
        {
            Console.WriteLine("面积为: " + ShapeArea);
        }

    }

    //圆形
    class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double r)
        {
            _radius = r;
            Create();
        }

        public override void Create()
        {
            ShapeArea = Math.PI * _radius * _radius;
        }
    }

    //矩形
    class Rect : Shape
    {
        private readonly double _width, _length;

        public Rect(double w, double l)
        {
            _width = w;
            _length = l;
            Create();
        }

        public override void Create()
        {
            ShapeArea = _width * _length;
        }
    }

    //三角形
    class Triangle : Shape
    {
        private readonly double _side, _height;

        public Triangle(double s, double h)
        {
            _side = s;
            _height = h;
            Create();
        }

        public override void Create()
        {
            ShapeArea = 0.5 * _side * _height;
        }
    }

    //正方形
    class Square : Shape
    {
        private readonly double _width;

        public Square(double w)
        {
            _width = w;
            Create();
        }

        public override void Create()
        {
            ShapeArea = _width * _width;
        }
    }

    //工厂
    public class ShapeFactory
    {
        public static Shape GetShape(string type, double a, double b = 0)
        {
            Shape shape = null;
            if (type.SequenceEqual("circle"))
            {
                shape = new Circle(a);
            }
            else if (type.SequenceEqual("rect"))
            {
                shape = new Rect(a,b);
            }
            else if (type.SequenceEqual("triangle"))
            {
                shape = new Triangle(a,b);
            }
            else if (type.SequenceEqual("square"))
            {
                shape = new Square(a);
            }

            return shape;
        }
    }


    class Program
    {
        static void Main()
        {
            Shape shape;
            //圆形
            Console.WriteLine("创建半径为5的圆形");
            shape = ShapeFactory.GetShape("circle", 5);
            shape.ShowArea();
            //矩形
            Console.WriteLine("创建边长为2, 4的矩形");
            shape = ShapeFactory.GetShape("rect", 2, 4);
            shape.ShowArea();
            //三角形
            Console.WriteLine("创建底3, 高4的三角形");
            shape = ShapeFactory.GetShape("triangle", 3, 4);
            shape.ShowArea();
            //正方形
            Console.WriteLine("创建边长为1的正方形");
            shape = ShapeFactory.GetShape("square", 1);
            shape.ShowArea();
            Console.ReadKey();
        }
    }
}


