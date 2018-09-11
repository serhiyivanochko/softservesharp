using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void DelegateEx();

        public static void MethodA()
        {
            Console.WriteLine("MethodA");
        }
        public static void MethodB()
        {
            Console.WriteLine("MethodB");
        }
        public static void MethodC()
        {
            Console.WriteLine("MethodC");
        }
   
        static void Main(string[] args)
        {
            
            DelegateEx DEx = new DelegateEx(MethodA);
            DEx();
            
            DEx = MethodB;
            DEx();

            DEx = new DelegateEx(MethodC);
            DEx();


            Console.WriteLine("\n-----Group-----\n");

            DelegateEx MA = MethodA;
            DelegateEx MB = MethodB;
            DelegateEx MC = MethodC;
            
           
            DEx = MA; 
            DEx = DEx + MC; 
            DEx += MB; // MethodA->MethodC->MethodB
            DEx();
            Console.WriteLine();

            DEx -= MB; // MethodA->MethodC
            DEx();// MethodC
            Console.WriteLine();

            DEx += MA; // MethodA->MethodC->MethodA
            DEx(); // MethodA
            Console.WriteLine();

            DEx -= MA; // MethodA->MethodC
            DEx(); // MethodC
            Console.WriteLine();

            DEx -= MA; // MethodC
            DEx();
            Console.WriteLine();

            DEx -= MC; // DEx => Empty


        }

    }
}
