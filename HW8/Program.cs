using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    #region HomeWork
    public abstract class Shape
    {
        public string Name { get; set; }
        public Shape(string name) { this.Name = name; }
        public abstract double Area();
        public abstract double Perimeter();

    }
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(string name, int radius) : base(name)
        {
            this.Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

    }
    public class Square : Shape
    {
        public int Side { get; set; }
        public Square(string name, int side) : base(name)
        {
            this.Side = side;
        }
        public override double Area()
        {
            return this.Side * this.Side;
        }

        public override double Perimeter()
        {
            return this.Side * 4;
        }

    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //List<int> list = new List<int>();
            //for (int i = 0; i < 10; i++) {
            //    Console.Write("Enter {0} number:", i+1);
            //    list.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            //var items = from s in list
            //            where s<0
            //            select s;
            //Console.WriteLine("Numbers <0: ");
            //foreach (var current in items) {
            //    Console.Write(current + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Numbers >0 and paired: ");
            //items = from s in list
            //            where s > 0 where s % 2 == 0
            //            select s;

            //foreach (var current in items)
            //{
            //    Console.Write(current + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Max: {0}",list.Max());
            //Console.WriteLine("Min: {0}", list.Min());
            //Console.WriteLine("Sum: {0}", list.Sum());
            //Console.WriteLine("First < Average: {0}", list.First(n => n < list.Average()));
            //IEnumerable<int> query = list.OrderBy(n => n);
            //Console.WriteLine("Sorted: ");
            //foreach (var current in query)
            //{
            //    Console.Write(current + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Homework
            #region Task A
            //List<Shape> list1 = new List<Shape>();
            //list1.Add(new Circle("Circle1", 10));
            //list1.Add(new Circle("Circle2", 3));
            //list1.Add(new Square("Square1", 5));
            //list1.Add(new Square("Square2", 7));
            //list1.Add(new Circle("Circle3", 1));
            //list1.Add(new Square("Square3", 11));

            //foreach (var current in list1)
            //{
            //    Console.WriteLine("Shape name: " + current.Name + ":\nArea: " + current.Area() + "\nPerimeter: " + current.Perimeter());
            //}
            //StreamWriter sr = new StreamWriter("output_range.txt");
            //try
            //{
            //    var results = from c in list1
            //                  where c.Area() > 10
            //                  where c.Area() < 100
            //                  select c;
            //    foreach (var current in results)
            //    {
            //        sr.WriteLine(current.Name);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.HResult);
            //}
            //finally
            //{
            //    sr.Close();
            //}
            //sr = new StreamWriter("output_name.txt");
            //try
            //{
            //    var results = from c in list1
            //                  where c.Name.Contains("a")
            //                  select c;
            //    foreach (var current in results)
            //    {
            //        sr.WriteLine(current.Name);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.HResult);
            //}
            //finally
            //{
            //    sr.Close();
            //}
            //Console.WriteLine();
            //var result = from c in list1
            //             where c.Perimeter() > 5
            //             select c;
            //foreach (var current in result)
            //{
            //    Console.WriteLine("Shape name: " + current.Name + ":\nArea: " + current.Area() + "\nPerimeter: " + current.Perimeter());
            //}
            #endregion

            #region Task B
            string[] lines = File.ReadAllLines("input.txt");
            int line = 1;
            foreach (var current in lines)
            {
                Console.WriteLine("Line {0}: Count word: {1}", line, current.Split(' ').Count());
                line++;
            }
            Console.WriteLine("Longest line: {0}", Array.IndexOf(lines, lines.OrderByDescending(s => s.Length).First()) + 1);
            Console.WriteLine("Shortest line: {0}", Array.IndexOf(lines, lines.OrderBy(s => s.Length).First()) + 1);
            Console.WriteLine("Contained word \"var\":");
            var results = (from c in lines
                          where c.Contains("var")
                          select c).ToArray();
            foreach (var current in results)
            {
                Console.WriteLine("\tLine {0}: {1}", Array.IndexOf(lines,current) , current);
            }
            #endregion
            #endregion
        }
    }
}
