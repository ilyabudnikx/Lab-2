using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания/функции:");
            int num_switch = Convert.ToInt32(Console.ReadLine());
            switch(num_switch)
            {
                case 1:
                    func1(args);  
                    break;
            }
        }
        static void func1(string[] args)
        {
            Console.WriteLine("sosi");
        }
    }
}
