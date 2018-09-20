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
        

        #region Properties

        public string Name { get; set; }
        public string Color { get; set; }

        #endregion

        #region Constructors

        public Fruit()
        {

        }

        public Fruit(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        #endregion

        #region Input

        public virtual void Input()
        {
            Console.Write("Enter fruit name: ");
            this.Name = Console.ReadLine();

            Console.Write("Enter fruit color: ");
            this.Color = Console.ReadLine();
        }

        public virtual void Input(string[] newFruit)
        {
            this.Name = newFruit[0];
            this.Color = newFruit[1];
        }

        #endregion

        #region Output

        public virtual void Output()
        {
            Console.WriteLine(this);
        }
        public virtual void Output(StreamWriter sr)
        {
            sr.WriteLine(this);
        }

        #endregion

        #region Other methods

        public override string ToString()
        {
            return $"Fruit: {this.Name}, fruit color: {this.Color}";
        }

        #endregion
    }
}
