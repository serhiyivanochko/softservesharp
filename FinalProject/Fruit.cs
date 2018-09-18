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
            this.name = name;
            this.color = color;
        }

        #endregion

        #region Input

        public virtual void Input()
        {
            Console.Write("Enter fruit name: ");
            this.name = Console.ReadLine();

            Console.Write("Enter fruit color: ");
            this.color = Console.ReadLine();
        }

        public virtual void Input(string[] newFruit)
        {
            name = newFruit[0];
            color = newFruit[1];
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
            return $"Fruit: {this.name}, fruit color: {this.color}";
        }

        #endregion
    }
}
