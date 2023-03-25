using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void DelegateHandler();
    public class EventDemo
    {
        public event DelegateHandler Demo;
        public void India()
        {
            Console.WriteLine("India");
        }
        public void USA()
        {
            Console.WriteLine("USA");
        }
        public void Russia()
        {
            Console.WriteLine("Russia");
        }
        public void Run()
        {
            Demo += new DelegateHandler(India);
            Demo += new DelegateHandler(USA);
            Demo += new DelegateHandler(Russia);
            Demo.Invoke();
        }
    }
}
