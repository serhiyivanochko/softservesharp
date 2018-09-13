using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public delegate void MyDel(int m);

    class Student {
        public string name { get; set; }
        public List<int> list { get; set; }
        public event MyDel MyEvent;
        public void AddMark(int mark) {
            list.Add(mark);

        }
    }
    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}
