using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FinalProject
{
    [Serializable]

    public class Citrus : Fruit
    {
        

        #region Properties

        public double Vitamin_c { get; set; }

        #endregion

        #region Constructors

        public Citrus()
        {

        }
        public Citrus(string name, string color, double vitamin_c) : base(name, color)
        {
            this.Vitamin_c = vitamin_c;
        }

        #endregion

        #region Inputs
        /// <summary>
        /// Input Citrus from Console
        /// </summary>
        public override void Input()
        {
            base.Input();
            Console.Write("Enter vitamin C in grams: ");

            while ((this.Vitamin_c = ToDouble(Console.ReadLine())) == 0)
            {
                Console.Write("Incorrect grams format.\r\nEnter vitamin C in grams: ");
            }
        }

        /// <summary>
        /// Input Citrus from file
        /// </summary>
        /// <param name="newFruit">Splitted string by ' ' symbol</param>
        public override void Input(string[] newFruit)
        {
            base.Input(newFruit);
            this.Vitamin_c = ToDouble(newFruit[2]);
        }

        #endregion

        #region Output
        /// <summary>
        /// Output Citrus to Console
        /// </summary>
        public override void Output()
        {
            Console.WriteLine(this);
        }
        
        /// <summary>
        /// Output Citrus to File
        /// </summary>
        /// <param name="sr">Stream for output</param>
        public override void Output(StreamWriter sr)
        {
            sr.WriteLine(this);
        }

        #endregion

        #region Other methods
        /// <summary>
        /// Convert string to double
        /// </summary>
        /// <param name="inputString">string double value</param>
        /// <returns></returns>
        public static double ToDouble(string inputString)
        {
            double result;

            if (!double.TryParse(inputString, NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                !double.TryParse(inputString, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                !double.TryParse(inputString, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                return 0;
            }
            else
            {
                return result;
            }
        }

        /// <summary>
        /// Convert object to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}, vitamine C: {this.Vitamin_c}gr.";
        }
        #endregion
    }
}
