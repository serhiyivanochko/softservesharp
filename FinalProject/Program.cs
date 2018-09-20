using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FinalProject
{
    public class Program
    {
        //String.Format(); Using

        #region Methods
        /// <summary>
            /// Find and output to Console items with input color
            /// </summary>
            /// <param name="list">List items</param>
            /// <param name="color">Color for searching</param>
        public static void FindByColor(List<Fruit> list, string color)
        {
            Console.WriteLine($"\nFind by color: {color}:");
            var result = list.Where(x => x.Color.ToLower() == color.ToLower());

            foreach (var current in result)
            {
                current.Output();
            }
        }

        /// <summary>
        /// Sort list by Name of Fruit object
        /// </summary>
        /// <param name="list">List of items</param>
        /// <returns>Sorted list</returns>
        public static List<Fruit> Sort(List<Fruit> list)
        {
            return list.OrderBy(x => x.Name).ToList();
        }

        /// <summary>
        /// Output sorted list to Console
        /// </summary>
        /// <param name="list">List of items</param>
        /// <returns>Result message</returns>
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

        /// <summary>
        /// Serialize list to XML document
        /// </summary>
        /// <param name="list">List of items</param>
        /// <returns>Result message</returns>
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

        /// <summary>
        /// Deserialize XML document to list of fruits
        /// </summary>
        /// <returns>List of items</returns>
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

        /// <summary>
        /// Create List of items from file
        /// </summary>
        /// <returns>List of items</returns>
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

        /// <summary>
        /// Output List of items to Console
        /// </summary>
        /// <param name="list"></param>
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
