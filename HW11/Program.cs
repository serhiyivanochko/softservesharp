using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW11
{
    [Serializable]
    public class Car
    {
        #region Fields
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public const string CompanyName = "MyCompamny";
        #endregion
        #region Constructors
        Car() { }
        public Car(string _name, string _color, int _price)
        {
            this.Name = _name;
            this.Color = _color;
            this.Price = _price;
        }
        #endregion
        #region Methods
        public Car Input()
        {
            Car car = new Car();
            car.Name = Console.ReadLine();
            car.Color = Console.ReadLine();
            car.Price = Convert.ToInt32(Console.ReadLine());
            return car;
        }
        public void Print()
        {
            Console.WriteLine("Car: {0}", this.Name);
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Price: {0}", this.Price);
        }
        public void ChangePrice(double x)
        {
            this.Price = Convert.ToInt32(this.Price - (this.Price * (x / 100)));
        }
        #endregion
        #region Override
        public static bool operator ==(Car car1, Car car2)
        {
            if (car1.Name == car2.Name && car1.Price == car2.Price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Car car1, Car car2)
        {
            if (car1.Name == car2.Name && car1.Price == car2.Price)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string ToString()
        {
            return "Name:" + this.Name + " Price:" + this.Price + " Color:" + this.Color;
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Binary
            Car c = new Car("Car1", "Red", 1000);

            Stream stream = File.Open("binary_serialization.txt", FileMode.Create);
            try
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, c);
                Console.WriteLine("Binary serialization completed!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.HResult);
            }
            finally
            {
                stream.Close();
            }
            #endregion

            #region XML
            XmlSerializer xml_s = new XmlSerializer(typeof(Car));
            StreamWriter sw = new StreamWriter("xml_serialization.xml");
            try
            {
                xml_s.Serialize(sw, c);
                Console.WriteLine("XML serialization completed!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.HResult);
            }
            finally
            {
                sw.Close();
            }
            #endregion

            #region Json

            sw = new StreamWriter("json_serialization.txt");
            try
            {
                var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(c);
                sw.WriteLine(jsonString);
                Console.WriteLine("JSON serialization completed!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.HResult);
            }
            finally
            {
                sw.Close();
            }

            #endregion

        }
    }
}
