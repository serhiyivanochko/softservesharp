using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    interface IFlyable {
        void Fly();
    }
    class Bird : IFlyable {
        
        string Name { get; set; }
        public Bird(string name) {
            this.Name = name;
        }
        void canFly() {
            Console.WriteLine("BirdFly");
        }
        void IFlyable.Fly()
        {
            canFly();
        }
    }
    class Plane : IFlyable {
        string Mark { get; set; }
        public Plane(string mark) {
            this.Mark = mark;
        }
        void highFly() {
            Console.WriteLine("PlaneFly");
        }
        void IFlyable.Fly()
        {
            highFly();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> list = new List<IFlyable>();
            list.Add(new Bird("Bird1"));
            list.Add(new Plane("Plane1"));
            list.Add(new Bird("Bird2"));
            list.Add(new Plane("Plane2"));
            list.Add(new Bird("Bird3"));
            list.Add(new Plane("Plane3"));

            foreach (var current in list) {
                current.Fly();
            }

        }
    }
}
