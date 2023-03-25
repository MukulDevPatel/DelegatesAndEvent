using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class DelegateDemo
    {
        public class SingleCastDelegate
        {
            public int Addition(int x, int y)
            {
                int a = 1;
                int b = 2;
                return a + b;
            }
            public void Run()
            {
                Console.WriteLine(Addition(1, 2));
            }
        }
    }
}
