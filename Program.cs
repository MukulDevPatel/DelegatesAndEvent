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
                Console.WriteLine("\n1. Single cast delegate\n2. MultiCast Delegate\n3. Event Demo\n4. Exit");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {

                    case 1:
                        SingleCastDelegate single = new SingleCastDelegate();
                        single.Run();
                        break;
                    case 2:
                        MultiCastDelegate multi = new MultiCastDelegate();
                        multi.Run();
                        break;
                    case 3:
                        EventDemo demo = new EventDemo();
                        demo.Run();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
                
            }
        }
    }
}
