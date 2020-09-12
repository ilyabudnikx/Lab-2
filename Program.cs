using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания/функции:\n");
            Console.WriteLine(" 1)Типы.\n 2)Строки.\n 3)Массивы.\n 4)Кортежи.\n 5)Работа с массивами.\n 6)Работа с checked/unchecked.\n");
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
            Console.WriteLine("Тип bool:");
            bool check = true;
            Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked
            Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked
            Console.WriteLine("Тип byte:");
            byte a = 254;
            Console.WriteLine(a);
            Console.WriteLine("Тип sbyte:");
            sbyte b = -128;
            Console.WriteLine(b);
            Console.WriteLine("Тип char:");
            char c = 's';
            Console.WriteLine(c);
           
        }
    }
}
