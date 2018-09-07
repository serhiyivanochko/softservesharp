using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class Program
    {
        #region Task 1
        static double Div(double num1, double num2) {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException e) {
                return e.HResult;
            }
            
        }
        #endregion

        #region Task2

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

        #region Task4

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
            catch {
                Console.WriteLine("Error");
            }
            #endregion

            #region Task3
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            List<string> list = new List<string>();
            ReadFolder(list, dir);
            StreamWriter sw1 = new StreamWriter("DirectoryC.txt");
            foreach (var current in list) {
                try
                {
                    sw1.WriteLine(current);
                }
                catch { }
            }
            sw1.Close();



            #endregion

            #region Task4
            string sourceDir = @"D:\";
            string[] txtList = null;
            try
            {
                txtList = Directory.GetFiles(sourceDir, "*.txt");
            }
            catch { }
            foreach (var current in txtList) {
                Console.WriteLine(File.ReadAllText(current));
            }
            #endregion
        }
    }
}
