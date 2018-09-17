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
   
    public class Citrus: Fruit
    {
        #region Fields

        double vitamin_c;

        #region Properties

        public double Vitamin_c
        {
            get
            {
                return vitamin_c;
            }
            set
            {
                vitamin_c = value;
            }
        }

        #endregion

        #endregion

        #region Constructors

        public Citrus() { }
        public Citrus(string name, string color, double _vitamin_c) : base(name, color)
        {
            this.vitamin_c = _vitamin_c;
        }

        #endregion

        #region Inputs

        public override void Input()
        {
            base.Input();
            Console.Write("Enter vitamin C in grams: ");
            while ((vitamin_c = ToDouble(Console.ReadLine()))==0)
            {
                Console.Write("Incorrect grams format.\r\nEnter vitamin C in grams: ");
            }
        }
        public override void Input(string[] new_fruit)
        {
            base.Input(new_fruit);
            this.vitamin_c = ToDouble(new_fruit[2]);
        }

        #endregion

        #region Output

        public override void Output()
        {
            Console.WriteLine(ToString());
        }
        public override void Output(StreamWriter sr)
        {
            sr.Write(ToString());
        }

        #endregion

        #region Other methods
        public static double ToDouble(string buff_str)
        {
            double result;
            if (!double.TryParse(buff_str, NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                !double.TryParse(buff_str, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                !double.TryParse(buff_str, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                return 0;
            }
            else
            {
                return result;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, vitamine C: {vitamin_c}gr.";
        }
        #endregion
    }
}
