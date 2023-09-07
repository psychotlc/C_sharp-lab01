using System;
using System.Formats.Asn1;

namespace lab1
{
    class Program{
        static void Main(string[] args){
            task1.solution();
            task2.solution();
            task3.solution();

        }
    }
    public class task1{
        public static void solution(){
            Console.WriteLine("////////////////////////////task1////////////////////////////");
            Console.WriteLine($"sbyte:\n   Минимальное значение = {sbyte.MinValue},   Максимальное значение = {sbyte.MaxValue}");
            Console.WriteLine($"byte: \n   Минимальное значение = {byte.MinValue},    Максимальное значение = {byte.MaxValue}");
            Console.WriteLine($"short:\n   Минимальное значение = {short.MinValue},   Максимальное значение = {short.MaxValue}");
            Console.WriteLine($"ushort:\n  Минимальное значение = {ushort.MinValue},  Максимальное значение = {ushort.MaxValue}");
            Console.WriteLine($"int:\n     Минимальное значение = {int.MinValue},     Максимальное значение = {int.MaxValue}");
            Console.WriteLine($"uint:\n    Минимальное значение = {uint.MinValue},    Максимальное значение = {uint.MaxValue}");
            Console.WriteLine($"long:\n    Минимальное значение = {long.MinValue},    Максимальное значение = {long.MaxValue}");
            Console.WriteLine($"ulong:\n   Минимальное значение = {ulong.MinValue},   Максимальное значение = {ulong.MaxValue}");
            Console.WriteLine($"float:\n   Минимальное значение = {float.MinValue},   Максимальное значение = {float.MaxValue}");
            Console.WriteLine($"double:\n  Минимальное значение = {double.MinValue},  Максимальное значение = {double.MaxValue}");
            Console.WriteLine($"decimal:\n Минимальное значение = {decimal.MinValue}, Максимальное значение = {decimal.MaxValue}");
        }
    };

    public class task2 {

        public class Rectangle{
            double side1;
            double side2;
            public double Area {
                get { return CalculateArea();}
            }
            public double Perimeter{
                get { return CalculatePerimeter();}
            }


            public Rectangle(double sideA, double sideB){
                side1 = sideA;
                side2 = sideB;
            }

            private double CalculateArea(){
                return side1 * side2;
            }

            private double CalculatePerimeter(){
                return 2 * (side1 + side2);
            }

        }

        public static void solution(){
            Console.WriteLine("////////////////////////////task2////////////////////////////");
            Console.WriteLine("Enter side1 length: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side2 length: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle Rect = new Rectangle(side1, side2);

            Console.WriteLine($"Area = {Rect.Area}");
            Console.WriteLine($"Perimeter = {Rect.Perimeter}");

        }
    }

    public class task3 {

        public class Point{
            int x;
            int y;

            public Point(int x, int y){
                this.x = x;
                this.y = y;
            }

            public int X{
                get { return x;}
            }

            public int Y {
                get { return y;}
            }
        }

        public class Figure{

            Point [] points;
            public string name{ get; set;}

            public Figure(Point p1, Point p2, Point p3) : this(new Point[] {p1, p2, p3}, "triangle") {}

            public Figure(Point p1, Point p2, Point p3, Point p4) : this(new Point[] {p1, p2, p3, p4}, "rectangle") {}
            
            public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(new Point[] {p1, p2, p3, p4, p5}, "pentagon") {}

            public Figure (Point [] points, string name){
                this.points = points;
                this.name = name;
            }

            public double LengthSide(Point A, Point B) {
                return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            }

            public double PerimeterCalculator() {
                double Perimeter = 0.0;

                for (int i = 0; i < points.Length; i++){
                    int NextIndex = (i + 1) % points.Length;
                    Perimeter += LengthSide(points[i], points[NextIndex]);
                }

                return Perimeter;
            }

        }

        public static void solution(){
            Console.WriteLine("////////////////////////////task3////////////////////////////");
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 0);
            Point p3 = new Point(0, 1);
            Point p4 = new Point(1, 1);
            Point p5 = new Point(2, 2);

            Figure triangle = new Figure(p1, p2, p3);
            Figure rectangle = new Figure(p1, p2, p3, p4);
            Figure pentagon = new Figure(p1, p2, p3, p4, p5);

            Console.WriteLine(triangle.PerimeterCalculator());
            Console.WriteLine(rectangle.PerimeterCalculator());
            Console.WriteLine(pentagon.PerimeterCalculator());
        }

    }
}