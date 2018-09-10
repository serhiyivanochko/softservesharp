using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    #region Task
    public class Person
    {
        private string name;
        public Person(string name)
        { this.name = name; }
        virtual public string Name { get { return name; } }
        virtual public void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
    }
    public class Staff : Person
    {
        private int salary;
        public Staff(string name, int salary) : base(name)
        { this.salary = salary; }
        override public string Name { get { return base.Name; } }
        override public void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1}", Name, this.salary);
        }
    }
    public class Teacher : Staff {
    
        public string subject { get; set; }
        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }
 
        public override void Print()
        {
            Console.WriteLine("Teacher's subject: {0}",this.subject);
        }
    }
    public class Developer : Staff {
        public string level { get; set; }
        public Developer(string name, int salary, string level) : base(name, salary)
        {
            this.level = level;
        }
        public override void Print()
        {
            Console.WriteLine("Developer's level: {0}", this.level);
        }
    }
    #endregion

    #region HomeWork
    public abstract class Shape {
        public string Name { get; set; }
        public Shape(string name) { this.Name = name; }
        public abstract double Area();
        public abstract double Perimeter();
       
    }
    public class Circle : Shape {
        public int Radius { get; set; }
        public Circle(string name, int radius) : base(name) {
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
            return this.Side*4;
        }
       
    }

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //List<Person> list = new List<Person>();
            //list.Add(new Teacher("Teacher1", 1000, "Math"));
            //list.Add(new Developer("Developer1", 10000, "Junior"));
            //list.Add(new Staff("Staff1",500));
            //string str = Console.ReadLine();
            //foreach (var current in list) {
            //    if (current.Name == str) {
            //        current.Print();
            //    }
            //}
            #endregion
            #region Homework
            List<Shape> list1 = new List<Shape>();
            list1.Add(new Circle("Circle1", 10));
            list1.Add(new Circle("Circle2", 3));
            list1.Add(new Square("Square1", 5));
            list1.Add(new Square("Square2", 7));
            list1.Add(new Circle("Circle3", 9));
            list1.Add(new Square("Square3", 11));
            list1.Add(new Circle("Circle4", 23));
            list1.Add(new Square("Square4", 22));
            list1.Add(new Circle("Circle5", 45));
            list1.Add(new Square("Square5", 7));
            Shape max_p = list1[0];
            foreach (var current in list1) {
                Console.WriteLine("Shape name: " + current.Name + ":\nArea: " + current.Area() + "\nPerimeter: " + current.Perimeter());
                if (max_p.Perimeter() < current.Perimeter()) { max_p = current; }
            }
            Console.WriteLine("Max perimeter in {0}",max_p.Name);
            #endregion
        }
    }
}
