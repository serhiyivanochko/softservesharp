using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tasks

            #region Task 1
            int a, b, count = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b > a)
            {
                int c = b;
                b = a;
                a = b;
            }
            for (int i = a; i < b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Count = {0}", count);
            #endregion

            #region Task 2
            string str = Console.ReadLine();
            for (int i = 1; i < str.Length; i += 2)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            #endregion

            #region Task 3
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Coffe", 100);
            dic.Add("Tea", 50);
            dic.Add("Juice", 70);
            dic.Add("Water", 10);
            string name = Console.ReadLine();
            Console.WriteLine(dic[name]);
            #endregion

            #region Task 4
            int sum = 0, scount = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            while (number >= 0)
            {
                sum += number;
                scount++;
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum / scount);
            #endregion

            #region Task 5
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    Console.WriteLine("Intercalary");
                }
                else
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Intercalary");
                    }
                    else
                    {
                        Console.WriteLine("No intercalary");
                    }
                }
            }
            else
            {
                Console.WriteLine("No intercalary");
            }
            #endregion

            #region Task 6
            int snumber = Convert.ToInt32(Console.ReadLine());
            int ssum = 0;
            while (snumber > 0)
            {
                int current = snumber - snumber / 10 * 10;
                ssum += current;
                snumber /= 10;
            }
            Console.WriteLine("Sum = {0}", ssum);
            #endregion

            #region Task 7
            int qnumber = Convert.ToInt32(Console.ReadLine());
            int count_dig = 0, count_np = 0;
            int buf_qnumber = qnumber;
            while (buf_qnumber > 0)
            {
                buf_qnumber /= 10;
                count_dig++;
            }

            buf_qnumber = qnumber;
            while (buf_qnumber > 0)
            {
                int current = buf_qnumber - buf_qnumber / 10 * 10;
                if (current % 2 == 1)
                {
                    count_np++;
                }
                buf_qnumber /= 10;
            }
            if (count_np == count_dig)
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
            #region Task A
            string text = Console.ReadLine();
            int count_a = 0, count_o = 0, count_i = 0, count_e = 0;
            foreach (var current in text)
            {
                if (current == 'a')
                    count_a++;
                if (current == 'o')
                    count_o++;
                if (current == 'i')
                    count_i++;
                if (current == 'e')
                    count_e++;
            }
            Console.WriteLine("Count 'a': {0}", count_a);
            Console.WriteLine("Count 'o': {0}", count_o);
            Console.WriteLine("Count 'i': {0}", count_i);
            Console.WriteLine("Count 'e': {0}", count_e);
            #endregion

            #region Task B
            Dictionary<string, int> Month = new Dictionary<string, int>();
            Month.Add("January", 31);
            Month.Add("February", 28);
            Month.Add("March", 31);
            Month.Add("April", 30);
            Month.Add("May", 31);
            Month.Add("June", 30);
            Month.Add("July", 31);
            Month.Add("August", 31);
            Month.Add("September", 30);
            Month.Add("October", 31);
            Month.Add("November", 30);
            Month.Add("December", 31);

            string cur_month = Console.ReadLine();
            Console.WriteLine(Month[cur_month]);

            #endregion

            #region Task C
            int[] arr = new int[10];
            int count_pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (i < 5 && arr[i] > 0)
                {
                    count_pos++;
                }
            }
            if (count_pos == 5)
            {
                int s_sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    s_sum += arr[i];
                }
                Console.WriteLine("Sum = {0}", s_sum);
            }
            else
            {
                int s_mod = 1;
                for (int i = arr.Length - 1; i > arr.Length - 6; i--)
                {
                    s_mod *= arr[i];
                }
                Console.WriteLine("Mod = {0}", s_mod);
            }
            #endregion

            #endregion
        }
    }
}
