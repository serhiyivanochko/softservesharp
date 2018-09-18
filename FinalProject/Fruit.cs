using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FinalProject
{
    
    [Serializable]
    [XmlInclude(typeof(Citrus))]
    public class Fruit
    {
        #region Fields

        string name;
        string color;

        #region Properties

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        
        #endregion

        #endregion

        #region Constructors

        public Fruit() { }
        public Fruit(string name, string color) {
            this.name = name;
            this.color = color;
        }

        #endregion

        #region Input

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

        #endregion

        #region Output

        public virtual void Output() {
            Console.WriteLine(ToString());
        }
        public virtual void Output(StreamWriter sr) {
            sr.WriteLine(ToString());
        }

        #endregion

        #region Other methods

        public override string ToString()
        {
            return $"Fruit: {this.name}, fruit color: {this.color}";
        }

        #endregion
    }
}
