using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        public static event EventHandler MyEvent
        {
            add
            {
                Console.WriteLine("Add operation");
            }

            remove
            {
                Console.WriteLine("Remove operation");
            }
        }


        delegate void DelegateEx();

        static event DelegateEx myEvent;

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

         


            MyEvent += new EventHandler(DoNothing);
            MyEvent -= null;



            myEvent = MethodA;
            myEvent += MethodB;
            myEvent += MethodC;

            Console.WriteLine();
            myEvent();

            myEvent -= MethodA;
            myEvent += MethodB;


            Console.WriteLine();
            myEvent();





        }

        private static void DoNothing(object sender, EventArgs e)
        {

        }
    }
}
