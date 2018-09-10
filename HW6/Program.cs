using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW6
{
    class Program
    {
        #region Task 1
        static double Div(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                return e.HResult;
            }

        }
        #endregion

        #region Task3
        static void ReadFolder(List<string> list, DirectoryInfo dir)
        {


            DirectoryInfo[] curr_dir = dir.GetDirectories();
            FileInfo[] curr_files = dir.GetFiles();
            list.Add(dir.Name + " Folder");
            foreach (var current in curr_dir)
            {
                try
                {
                    ReadFolder(list, current);
                }
                catch
                {
                }
            }
            foreach (var current in curr_files)
            {
                list.Add(current.Name + " File " + current.Length);
            }

        }
        #endregion

        #region Homework 2
        static string Output(object obj, int start, int end)
        {
            try
            {
                if (Convert.ToInt32(obj) > start && Convert.ToInt32(obj) < end)
                {
                    return obj.ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        #endregion

        static void Main(string[] args)
        {
            #region Task 1
            double num1 = 0.5, num2 = 0;
            Console.WriteLine(Div(num1, num2));
            #endregion

            #region Task2
            StreamReader sr = new StreamReader("data.txt");
            StreamWriter sw = new StreamWriter("rez.txt");

            string str;
            try
            {
                while ((str = sr.ReadLine()) != null)
                {
                    sw.WriteLine(str);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                sr.Close();
                sw.Close();
            }
            try
            {
                File.WriteAllText("rez.txt", File.ReadAllText("data.txt"));
            }
            catch
            {
                Console.WriteLine("Error");
            }
            #endregion

            #region Task3
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            List<string> list = new List<string>();
            ReadFolder(list, dir);
            StreamWriter sw1 = new StreamWriter("DirectoryC.txt");
            try
            {
                foreach (var current in list)
                {

                    sw1.WriteLine(current);

                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally { sw1.Close(); }




            #endregion

            #region Task4
            string sourceDir = @"D:\";
            string[] txtList = null;
            try
            {
                txtList = Directory.GetFiles(sourceDir, "*.txt");
            }
            catch { }
            foreach (var current in txtList)
            {
                Console.WriteLine(File.ReadAllText(current));
            }
            #endregion

            #region HomeWork 1
            Dictionary<string, string> dic = new Dictionary<string, string>();
            StreamReader sr1 = new StreamReader("phones.txt");
            try
            {
                string str1;
                while ((str1 = sr1.ReadLine()) != null)
                {
                    string[] dic_buf = str1.Split(';');
                    dic.Add(dic_buf[0], dic_buf[1]);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally { sr1.Close(); }

            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            try
            {
                Console.WriteLine("Phone: {0}", dic[name]);
            }
            catch
            {
                Console.WriteLine("Cannot find number");
            }

            StreamWriter sw2 = new StreamWriter("Phone.txt");
            try
            {
                foreach (var current in dic)
                {
                    sw2.WriteLine(current.Value);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally { sw2.Close(); }

            string regex = @"^80\d{9}$";

            for (int i = 0; i < dic.Keys.Count; i++)
            {
                if (Regex.Match(dic.Values.ElementAt(i), regex).Success)
                {
                    dic[dic.Keys.ElementAt(i)] = dic.Values.ElementAt(i).Replace("80", "+380");
                }

            }

            sw2 = new StreamWriter("New.txt");
            try
            {
                foreach (var current in dic)
                {
                    sw2.WriteLine(current.Key + ";" + current.Value);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally { sw2.Close(); }

            #endregion

            #region HomeWork 2
            object a = "";
            int c = 0;
            do
            {
                Console.WriteLine("Enter smth");
                a = Console.ReadLine();
                int nextmin = 0;
                try
                {
                    nextmin = Convert.ToInt32(Output(a, nextmin, 100));
                    c++;
                }
                catch { }

            } while (c < 10);

            #endregion
        }
    }
}
