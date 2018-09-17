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
        #region Constants

        const string SerializeFile = "Serialize.xml";
        const string SortFile = "Sorted.txt";
        const string FruitFile = "Fruits.txt";

        #endregion

        #region Methods

        public static void FindByColor(List<Fruit> list, string color) {
            Console.WriteLine($"\nFind by color: {color}:");
            var result = list.Where(x => x.Color.ToLower() == color.ToLower());
            foreach (var current in result) {
                current.Output();
            }
        }

        public static List<Fruit> Sort(List<Fruit> list) {
            return list.OrderBy(x=>x.Name).ToList();
        }

        public static string OutputSorted(List<Fruit> list) {
            StreamWriter sw = new StreamWriter(SortFile);
            try
            {
                foreach (var current in list)
                {
                    current.Output(sw);
                }
                return "\nSorted.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                sw.Close();
            }
            
        }

        public static string Serialize(List<Fruit> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Fruit>));
            FileStream fs = new FileStream(SerializeFile, FileMode.OpenOrCreate);
            fs.SetLength(0);
            try
            {
                formatter.Serialize(fs, list);
                return "\nSerialized.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                fs.Close();
            }
        }

        public static List<Fruit> Deserialize() {
            List<Fruit> list = new List<Fruit>();
            var serializer = new XmlSerializer(typeof(List<Fruit>));

            var stream = File.OpenRead(SerializeFile);
            try
            {
                var other = (List<Fruit>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
                Console.WriteLine("\nDeserialized:");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                stream.Close();
            }
            return list;

        }

        public static List<Fruit> InputFormFile() {
            List<Fruit> list = new List<Fruit>();
            StreamReader sr = new StreamReader(FruitFile);
            string line;
            try
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] curr = line.Split(' ');
                    switch (curr.Length)
                    {
                        case 2:
                            Fruit f = new Fruit();
                            f.Input(curr);
                            list.Add(f);
                            break;
                        case 3:
                            Citrus f1 = new Citrus();
                            f1.Input(curr);
                            list.Add(f1);
                            break;

                        

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                sr.Close();
            }
            return list;
        }

        public static void OutputList(List<Fruit> list) {
            foreach (var current in list)
            {
                current.Output();
            }
        }

        #endregion

        static void Main(string[] args)
        {
            List<Fruit> fruit_list = InputFormFile();

            OutputList(fruit_list);

            FindByColor(fruit_list, "yellow");

            Console.WriteLine(OutputSorted(Sort(fruit_list)));

            Console.WriteLine(Serialize(fruit_list));

            List<Fruit> deserialized_list = Deserialize();

            OutputList(deserialized_list);

        }
    }
}
