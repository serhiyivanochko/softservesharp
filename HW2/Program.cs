using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        struct RGB
        {
            byte Red, Green, Blue;
        }
        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }
        enum HTTPError
        {
            e400,
            e401,
            e402,
            e404
        }
        struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;
            public string _toString()
            {
                return "Dog:\nName:" + this.Name + "\nMark:" + Mark + "\nAge:" + Age.ToString();
            }
        }
        static void Main(string[] args)
        {
            #region Tasks

            #region Task 1
            int day, month;
            Console.Write("Enter day number: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month number: ");
            month = Convert.ToInt32(Console.ReadLine());
            if (day < 31 && month < 12)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            #endregion

            #region Task 2
            Console.Write("Enter number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double buf = (num - (int)num) * 10;
            int num1 = (int)buf;
            int num2 = (int)((buf - num1) * 10);
            Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
            #endregion

            #region Task 3
            int hour = Convert.ToInt32(Console.ReadLine());
            if (hour >= 4 && hour < 11)
            {
                Console.WriteLine("Good Morning!");
            }
            if (hour >= 11 && hour < 16)
            {
                Console.WriteLine("Good Day!");
            }
            if (hour >= 16 && hour < 22)
            {
                Console.WriteLine("Good Evening!");
            }
            if ((hour >= 22 && hour < 24) || (hour >= 0 && hour < 4))
            {
                Console.WriteLine("Good Morning!");
            }
            #endregion

            #region Task 4

            TestCaseStatus test1Status = TestCaseStatus.Pass;
            if (test1Status == TestCaseStatus.Pass)
            {
                Console.WriteLine("Passed");
            }

            #endregion

            #region Task 5
            #endregion


            #endregion

            #region HomeWork

            #region Task A
            double f_num1, f_num2, f_num3;
            Console.Write("Enter first number: ");
            f_num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            f_num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number: ");
            f_num3 = Convert.ToDouble(Console.ReadLine());

            if (f_num1 >= -5 && f_num1 <= 5)
            {
                Console.WriteLine("{0} - True", f_num1);
            }
            if (f_num2 >= -5 && f_num2 <= 5)
            {
                Console.WriteLine("{0} - True", f_num2);
            }
            if (f_num3 >= -5 && f_num3 <= 5)
            {
                Console.WriteLine("{0} - True", f_num3);
            }
            #endregion
            #region Task B
            int i_num1, i_num2, i_num3;
            Console.Write("Enter first number: ");
            i_num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            i_num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            i_num3 = Convert.ToInt32(Console.ReadLine());
            if (i_num2 > i_num1)
            {
                if (i_num3 > i_num2)
                {
                    Console.WriteLine("Max = {0}", i_num3);
                }
                else
                {
                    Console.WriteLine("Max = {0}", i_num2);
                }
            }
            else
            {
                Console.WriteLine("Max = {0}", i_num1);
            }
            if (i_num2 < i_num1)
            {
                if (i_num3 < i_num2)
                {
                    Console.WriteLine("Min = {0}", i_num3);
                }
                else
                {
                    Console.WriteLine("Min = {0}", i_num2);
                }
            }
            else
            {
                Console.WriteLine("Min = {0}", i_num1);
            }
            #endregion
            #region Task C
            HTTPError h = HTTPError.e401;
            if (h == HTTPError.e401)
            {
                Console.WriteLine("Error 401");
            }
            #endregion

            #region Task D
            Dog d = new Dog();
            d.Name = Console.ReadLine();
            d.Mark = Console.ReadLine(); ;
            d.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(d._toString());
            #endregion
            #endregion
        }
    }
}