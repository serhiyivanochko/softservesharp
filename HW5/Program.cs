using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    #region Task 1
    interface IFlyable {
        void Fly();
    }
    class Bird : IFlyable {
        
        string Name { get; set; }
        bool canFly { get; set; }
        public Bird(string name, bool canfly) {
            this.Name = name;
            this.canFly = canfly;
        }
        void IFlyable.Fly()
        {
            if (this.canFly)
            {
                Console.WriteLine("Bird can fly");
            }
            else {
                Console.WriteLine("Bird can not fly");
            }
            
        }
    }
    class Plane : IFlyable {
        string Mark { get; set; }
        bool highFly { get; set; }
        public Plane(string mark, bool highfly) {
            this.Mark = mark;
            this.highFly = highfly;
        }
       
        void IFlyable.Fly()
        {
            if (this.highFly)
            {
                Console.WriteLine("Plane can not fly");
            }
            else
            {
                Console.WriteLine("Plane fly");
            }
        }
    }
    #endregion

    #region HomeWork
    interface IDeveloper {
        int Tool { get; set; }
        void Create();
        void Destoy();
    }
    class Programmer : IDeveloper
    {
        public int Tool { get; set; }
        public Programmer(int tool) {
            this.Tool = tool;
        }

        public void Create()
        {
            Console.WriteLine("Programmer {0} Created", this.Tool);
        }

        public void Destoy()
        {
            Console.WriteLine("Programmer {0} Destroyed", this.Tool);
        }
    }
    class Builder : IDeveloper
    {
        public int Tool { get; set; }
        public Builder(int tool) {
            this.Tool = tool;
        }

        public void Create()
        {
            Console.WriteLine("Builder {0} Created", Tool);
        }

        public void Destoy()
        {
            Console.WriteLine("Builder {0} Destroyed", Tool);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //List<IFlyable> list = new List<IFlyable>();
            //list.Add(new Bird("Bird1",true));
            //list.Add(new Plane("Plane1", true));
            //list.Add(new Bird("Bird2",false));
            //list.Add(new Plane("Plane2",false));
            //list.Add(new Bird("Bird3", true));
            //list.Add(new Plane("Plane3",false));

            //foreach (var current in list) {
            //    current.Fly();
            //}
            #endregion

            #region HomeWork
            List<IDeveloper> list = new List<IDeveloper>();
            list.Add(new Builder(1));
            list.Add(new Programmer(2));
            list.Add(new Builder(3));
            list.Add(new Programmer(4));
            list.Add(new Builder(5));
            list.Add(new Programmer(6));
            list.Add(new Builder(7));
            list.Add(new Programmer(8));

            foreach (var current in list) {
                current.Create();
                current.Destoy();
            }
            Dictionary<uint, string> dic = new Dictionary<uint, string>();
            for (int i = 0; i < 7; i++) {
                Console.WriteLine("Enter {0} user ID: ", i + 1);
                uint ID = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Enter {0} user Name: ", i + 1);
                string name = Console.ReadLine();
                dic.Add(ID, name);
            }
            Console.WriteLine("Enter user ID: ");
            uint fID = Convert.ToUInt32(Console.ReadLine());
            if (dic[fID] != null)
            {
                Console.WriteLine(dic[fID]);
            }
            else {
                Console.WriteLine("Can not find user with current ID");
            }

            #endregion
        }
    }
}
