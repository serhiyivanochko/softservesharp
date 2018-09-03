using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
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

    public class Person
    {
        #region Fields
        public string Name { get; set; }
        public DateTime birthYear { get; set; }
        #endregion
        #region Constructors
        public Person() { }
        public Person(string _name, DateTime _birthYear)
        {
            this.Name = _name;
            this.birthYear = _birthYear;
        }
        #endregion
        #region Methods
        public int Age()
        {
            int age = Convert.ToInt32(DateTime.Now.Subtract(birthYear).Days) / 365;
            return age;
        }
        public Person Input()
        {
            Console.Write("Enter person name:");
            string name = Console.ReadLine();
            Console.Write("Enter person birthday in format 'dd//MM//yyyy':");
            DateTime birth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            return new Person(name, birth);
        }
        public void ChangeName(string _name)
        {
            this.Name = _name;
        }
        public void Output()
        {
            Console.WriteLine(this.ToString());
        }
        #endregion
        #region Overrides
        public override string ToString()
        {
            return "Name:" + this.Name + " BirthYear:" + this.birthYear.Year;
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (person1.Name == person1.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Person person1, Person person2)
        {
            if (person1.Name == person1.Name)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }


    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //List<Car> list = new List<Car>();
            //list.Add(new Car("Car1", "Black", 20000));
            //list.Add(new Car("Car2", "White", 40000));
            //list.Add(new Car("Car3", "Red", 10000));
            //foreach (var current in list) {
            //    current.Print();
            //}
            //foreach (var current in list)
            //{
            //    current.ChangePrice(10);
            //}
            //Console.Write("Input new color: ");
            //string new_color = Console.ReadLine();
            //list[1].Color = new_color;
            #endregion
            #region HomeWork

            List<Person> listp = new List<Person>();
            for (int i = 0; i < 6; i++)
                listp.Add(new Person().Input());
            foreach (var current in listp)
            {
                Console.WriteLine("Name: {0}, Age: {1}", current.Name, current.Age());
            }
            foreach (var current in listp)
            {
                if (current.Age() < 16)
                {
                    current.ChangeName("Very Young");
                }
            }
            foreach (var current in listp)
            {
                current.Output();
            }
            foreach (var current in listp)
            {
                foreach (var c in listp)
                {
                    if (c == current)
                    {
                        Console.WriteLine("Equals");
                        c.Output();
                        current.Output();
                    }
                }
            }
            #endregion
        }
    }
}
