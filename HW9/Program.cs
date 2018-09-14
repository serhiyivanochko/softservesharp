using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public struct Point {
        int x { get; set; }
        int y { get; set; }
        public Point(int _x, int _y) {
            this.x = _x;
            this.y = _y;
        }
        public int Distance(Point p)
        {
            return Convert.ToInt32(
                        Math.Sqrt(
                           (this.x - p.x) * (this.x - p.x) +
                           (this.y - p.y) * (this.y - p.y)
                        )
                   );
        }
        public override string ToString()
        {
            return "\"("+this.x+","+this.y+")\"";
        }
    }
    public class Triangle {
        Point vertex1, vertex2, vertex3;
        public Triangle() { }
        public Triangle(Point _vertex1, Point _vertex2, Point _vertex3) {
            this.vertex1 = _vertex1;
            this.vertex2 = _vertex2;
            this.vertex3 = _vertex3;
        }
        public double Perimeter() {
            return vertex1.Distance(vertex2) + 
                vertex2.Distance(vertex3) + 
                vertex3.Distance(vertex1);
        }
        public double Square() {
            return Math.Sqrt(
                this.Perimeter() * 
                (this.Perimeter() - this.vertex1.Distance(this.vertex2)) * 
                (this.Perimeter() - this.vertex2.Distance(this.vertex3)) * 
                (this.Perimeter() - this.vertex3.Distance(this.vertex1))
                );
        }
        public void Print() {
            Console.WriteLine("Point 1: " + this.vertex1.ToString());
            Console.WriteLine("Point 2: " + this.vertex2.ToString());
            Console.WriteLine("Point 3: " + this.vertex3.ToString());
            Console.WriteLine("Perimeter: " + this.Perimeter());
            Console.WriteLine("Square: " + this.Square());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            Point p1, p2, p3;
            p1 = new Point(10, 20);
            p2 = new Point(20, 30);
            p3 = new Point(30, 10);
            Triangle tr1 = new Triangle(p1, p2, p3);
            tr1.Print();


        }
    }
}
