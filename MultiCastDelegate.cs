using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int MultiOperation(int x, int y);
    public class MultiCastDelegate
    {
        public static int Addition(int a, int b)
        {
            Console.WriteLine("Add" + "= " + (a + b));
            return a + b;
        }
        public static int Multiplication(int a, int b)
        {
            Console.WriteLine("Multi" + "= " + (a * b));
            return a * b;
        }
        public void Run()
        {
            MultiOperation multi = Addition;
            multi += Multiplication;
            multi(1, 2);
            multi(2, 3);
        }

    }
}
