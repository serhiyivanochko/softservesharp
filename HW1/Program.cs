using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tasks

            #region Task 1
            int a, b;
            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            if (b != 0)
            {
                Console.WriteLine(a / b);
            }
            #endregion

            #region Task 2
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine("You are " + answer);
            #endregion

            #region Task 3
            char sym1, sym2, sym3;
            Console.Write("Enter first symbol: ");
            sym1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second symbol: ");
            sym2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter third symbol: ");
            sym3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You enter {0},{1},{2}", sym1, sym2, sym3);
            #endregion

            #region Task 4
            int number1, number2;
            Console.Write("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > 0 && number2 > 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            #endregion

            #endregion

            #region HomeWork

            #region Task B
            Console.Write("Enter number: ");
            int _a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area = {0}", _a * _a);
            Console.WriteLine("Perimetr = {0}", (_a + _a) * 2);
            #endregion

            #region Task C
            string name;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}?", name);
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name = {0}, Age = {1}", name, age);
            #endregion

            #region Task D
            Console.Write("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Length = {0}", 2 * Math.PI * r);
            Console.WriteLine("Area = {0}", Math.PI * Math.Pow(r, 2));
            Console.WriteLine("Volume = {0}", (4 / 3) * Math.PI * Math.Pow(r, 3));

            #endregion

            #endregion

        }
    }
}