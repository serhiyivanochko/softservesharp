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
        /// <summary>
        /// Input Fruit from Console
        /// </summary>
        public virtual void Input()
        {
            Console.Write("Enter fruit name: ");
            this.Name = Console.ReadLine();

            Console.Write("Enter fruit color: ");
            this.Color = Console.ReadLine();
        }

        /// <summary>
        /// Input Fruit from file
        /// </summary>
        /// <param name="newFruit">Splitted string by ' ' symbol</param>
        public virtual void Input(string[] newFruit)
        {
            this.Name = newFruit[0];
            this.Color = newFruit[1];
        }

        #endregion

        #region Output
        /// <summary>
        /// Output Fruit to Console
        /// </summary>
        public virtual void Output()
        {
            Console.WriteLine(this);
        }

        /// <summary>
        /// Output Fruit to File
        /// </summary>
        /// <param name="sr">Stream for output</param>
        public virtual void Output(StreamWriter sr)
        {
            sr.WriteLine(this);
        }

        #endregion

        #region Other methods

        /// <summary>
        /// Convert object to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Fruit: {this.Name}, fruit color: {this.Color}";
        }

        #endregion
    }
}
