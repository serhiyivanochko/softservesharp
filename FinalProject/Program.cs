using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> fr = new List<Fruit>();
            //for (int i = 0; i < 5; i++) {
            //    Citrus c = new Citrus();
            //    c.Input();
            //    fr.Add(c);
            //}
            //foreach (var a in fr) {
            //    a.Output();
            //}
            StreamReader sr = new StreamReader("Fruits.txt");
            string line;
            while ((line = sr.ReadLine()) != null) {
                string[] curr = line.Split(' ');
                switch (curr.Length) {
                    case 2:
                        Fruit f = new Fruit();
                        f.Input(curr);
                        fr.Add(f);
                        break;
                    case 3:
                        Citrus f1 = new Citrus();
                        f1.Input(curr);
                        fr.Add(f1);
                        break;

                }
            }
            sr.Close();
            foreach (var a in fr) {
                a.Output();
            }

        }
    }
}
