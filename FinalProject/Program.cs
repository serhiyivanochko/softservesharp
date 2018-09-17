using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FinalProject
{
    class Program
    {
        public static void FindByColor(List<Fruit> list, string color) {
            var result = list.Where(x => x.Color.ToLower() == color.ToLower());
            foreach (var current in result) {
                current.Output();
            }
        }

        public static List<Fruit> Sort(List<Fruit> list) {
            return list.OrderBy(x=>x.Name).ToList();
        }

        public static void OutputSorted(List<Fruit> list) {
            foreach (var current in list) {
                current.Output();
            }
        }

        public static void Serialize(List<Fruit> list) {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Fruit>));
            using (FileStream fs = new FileStream("Serialize.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
                Console.WriteLine("\nSerialized");
            }
        }

        public static List<Fruit> Deserialize() {
            List<Fruit> list = new List<Fruit>();
            var serializer = new XmlSerializer(typeof(List<Fruit>));
            using (var stream = File.OpenRead("Serialize.xml"))
            {
                var other = (List<Fruit>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
            return list;
        }

        static void Main(string[] args)
        {
            List<Fruit> fr = new List<Fruit>();
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

            Console.WriteLine("\nFind by color: Yellow.\n");
            FindByColor(fr, "yellow");

            Console.WriteLine("\nSorted list.\n");
            OutputSorted(Sort(fr));

            Serialize(fr);

            List<Fruit> list = Deserialize();
            Console.WriteLine("\nDeserialize list.\n");
            foreach (var current in list) {
                current.Output();
            }

        }
    }
}
