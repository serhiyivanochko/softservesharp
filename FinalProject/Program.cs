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
        //String.Format(); Using
        //#region Constants

        //const string SerializeFile = "Serialize.xml";
        //const string SortFile = "Sorted.txt";
        //const string FruitFile = "Fruits.txt";

        //#endregion

        #region Methods

        public static void FindByColor(List<Fruit> list, string color)
        {
            Console.WriteLine($"\nFind by color: {color}:");
            var result = list.Where(x => x.Color.ToLower() == color.ToLower());

            foreach (var current in result)
            {
                current.Output();
            }
        }

        public static List<Fruit> Sort(List<Fruit> list)
        {
            return list.OrderBy(x => x.Name).ToList();
        }

        public static string OutputSorted(List<Fruit> list)
        {
            StreamWriter sw = new StreamWriter(GlobalConst.SortFile);
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
            StreamWriter sr = new StreamWriter(GlobalConst.SerializeFile,false);

            try
            {
                formatter.Serialize(sr, list);
                return "\nSerialized.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                sr.Close();
            }
        }

        public static List<Fruit> Deserialize()
        {
            List<Fruit> list = new List<Fruit>();
            var serializer = new XmlSerializer(typeof(List<Fruit>));
            var stream = File.OpenRead(GlobalConst.SerializeFile);

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
            finally
            {
                stream.Close();
            }
            return list;

        }

        public static List<Fruit> InputFormFile()
        {
            List<Fruit> list = new List<Fruit>();
            StreamReader sr = new StreamReader(GlobalConst.FruitFile);
            string line;

            try
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] currentLine = line.Split(' ');

                    switch (currentLine.Length)
                    {
                        case 2:
                            Fruit newFruit = new Fruit();
                            newFruit.Input(currentLine);
                            list.Add(newFruit);
                            break;
                        case 3:
                            Citrus newCitrus = new Citrus();
                            newCitrus.Input(currentLine);
                            list.Add(newCitrus);
                            break;
                        default:
                            Console.WriteLine($"{currentLine[0]} {currentLine[1]} {currentLine[2]} there are some error in file.\n");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
            return list;
        }

        public static void OutputList(List<Fruit> list)
        {
            foreach (var current in list)
            {
                current.Output();
            }
        }

        #endregion

        static void Main(string[] args)
        {
            List<Fruit> fruitList = InputFormFile();

            OutputList(fruitList);

            FindByColor(fruitList, "yellow");

            Console.WriteLine(OutputSorted(Sort(fruitList)));

            Console.WriteLine(Serialize(fruitList));

            List<Fruit> deserializedList = Deserialize();

            OutputList(deserializedList);

        }
    }
}
