﻿using System;
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
            this.vitamin_c = vitamin_c;
        }

        #endregion

        #region Inputs

        public override void Input()
        {
            base.Input();
            Console.Write("Enter vitamin C in grams: ");

            while ((vitamin_c = ToDouble(Console.ReadLine())) == 0)
            {
                Console.Write("Incorrect grams format.\r\nEnter vitamin C in grams: ");
            }
        }
        public override void Input(string[] newFruit)
        {
            base.Input(newFruit);
            this.vitamin_c = ToDouble(newFruit[2]);
        }

        #endregion

        #region Output

        public override void Output()
        {
            Console.WriteLine(this);
        }
        public override void Output(StreamWriter sr)
        {
            sr.WriteLine(this);
        }

        #endregion

        #region Other methods
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

        public override string ToString()
        {
            return $"{base.ToString()}, vitamine C: {vitamin_c}gr.";
        }
        #endregion
    }
}