using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++) {
                Console.Write("Enter {0} number:", i+1);
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var items = from s in list
                        where s<0
                        select s;
            foreach (var current in items) {
                Console.Write(current + " ");
            }
            Console.WriteLine();

            items = from s in list
                        where s > 0 where s % 2 == 0
                        select s;

            foreach (var current in items)
            {
                Console.Write(current + " ");
            }
            Console.WriteLine();

            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.First(n => n < list.Average()));
            list.OrderBy(n => n);
            foreach (var current in items)
            {
                Console.Write(current + " ");
            }
            Console.WriteLine();
        }
    }
}
