using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Fruit
    {
        public string name { get; set; }
        public string color { get; set; }
        public Fruit() { }
        public Fruit(string name, string color) {
            this.name = name;
            this.color = color;
        }

        public virtual void Input() {
            Console.Write("Enter fruit name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter fruit color: ");
            this.color = Console.ReadLine();
        }
        public virtual void Input(string[] new_fruit)
        {
                name = new_fruit[0];
                color = new_fruit[1];
        }

        public virtual void Output() {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Fruit: {this.name}, fruit color: {this.color}";
        }

    }
}
