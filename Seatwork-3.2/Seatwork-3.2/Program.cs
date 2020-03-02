using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seatwork_3._2
{

    public abstract class Shape
    {
        public abstract double Area();
        public abstract bool Correct();
    }
    class Rectangle : Shape
    {
        public double height { set; get; }
        public double width { set; get; }
        public Rectangle(double l, double w)
        {
            height = l;
            width = w;
        }
        public override double Area()
        {
            if (height > 0 && width > 0)
                return height * width;
            else return -1;
        }

        public override bool Correct()
        {
            return (height > 0 && width > 0);
        }
    }

    class Square : Shape
    {
        public double sideLength { set; get; }
        public Square(double s)
        {
            sideLength = s;
        }
        public override double Area()
        {
            if (sideLength > 0)
                return sideLength * sideLength;
            else return -1;
        }

        public override bool Correct()
        {
            return sideLength > 0;
        }
    }

    class Triangle : Shape
    {
        public double aLength { set; get; }
        public double bLength { set; get; }
        public double cLength { set; get; }
        public Triangle(double a, double b, double c)
        {
            aLength = a;
            bLength = b;
            cLength = c;
        }
        public override double Area()
        {
            if (aLength + bLength > cLength && aLength + cLength > bLength && bLength + cLength > aLength && aLength > 0 && bLength > 0 && cLength > 0)
            {
                double p = (aLength + bLength + cLength) / 2;
                return Math.Sqrt(p * (p - aLength) * (p - bLength) * (p - cLength));
            }
            else return -1;
        }

        public override bool Correct()
        {
            return (aLength + bLength > cLength && aLength + cLength > bLength && bLength + cLength > aLength && aLength > 0 && bLength > 0 && cLength > 0);
        }
    }

    class ShapeFactory
    {
        public static Shape createShape(double num)
        {
            return new Square(num);
        }
        public static Shape createShape(double num1, double num2)
        {
            return new Rectangle(num1, num2);
        }
        public static Shape createShape(double num1, double num2, double num3)
        {
            return new Triangle(num1, num2, num3);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            /*
            Rectangle r = new Rectangle(3.0, 4.0);
            Console.WriteLine(r.Area());
            Square s = new Square(3.0);
            Console.WriteLine(s.Area());
            Triangle t = new Triangle(3.0, 4.0, 5.0);
            Console.WriteLine(t.Area());
            */

            int shapeNum = 0;
            double sumArea = 0d;
            for (; ; )
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                switch (r.Next(0, 3))
                {
                    case 0:
                        {
                            Shape shape = ShapeFactory.createShape(r.Next(0, 100));
                            if (shape.Correct())
                            {
                                sumArea += shape.Area();
                                shapeNum++;
                                Console.WriteLine($"第{shapeNum}个图形是正方形，面积是{shape.Area()}。");
                            }
                        }
                        break;
                    case 1:
                        {
                            Shape shape = ShapeFactory.createShape(r.Next(0, 100), r.Next(0, 100));
                            if (shape.Correct())
                            {
                                sumArea += shape.Area();
                                shapeNum++;
                                Console.WriteLine($"第{shapeNum}个图形是长方形，面积是{shape.Area()}。");
                            }
                        }
                        break;
                    case 2:
                        {
                            Shape shape = ShapeFactory.createShape(r.Next(0, 100), r.Next(0, 100), r.Next(0, 100));
                            if (shape.Correct())
                            {
                                sumArea += shape.Area();
                                shapeNum++;
                                Console.WriteLine($"第{shapeNum}个图形是三角形，面积是{shape.Area()}。");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("出现错误"); break;
                }
                if (shapeNum == 10)
                    break;
            }
            Console.WriteLine($"这10个图形的总面积为{sumArea}。");

        }
    }
}
