using System;
using static DelegatesAndEvents.DelegateDemo;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for execution");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1. Single cast delegate\n2. Exit");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {

                    case 1:
                        SingleCastDelegate single = new SingleCastDelegate();
                        single.Run();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
                
            }
        }
    }
}
