using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

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

                case 2:
                    func2(args);
                    break;
            }
        }
        static void func1(string[] args)
        {

            //Типы
            Console.WriteLine("Тип bool:");
            bool check = true;
            Console.WriteLine(check ? "Checked" : "Not checked");  
            Console.WriteLine(false ? "Checked" : "Not checked");  
            Console.WriteLine("Тип byte:");
            byte a = 254;
            Console.WriteLine(a);
            Console.WriteLine("Тип sbyte:");
            sbyte b = -128;
            Console.WriteLine(b);
            Console.WriteLine("Тип char:");
            char c = 's';
            Console.WriteLine(c);
            Console.WriteLine("Тип decimal:");
            decimal d = 45.08M;
            Console.WriteLine(d);
            Console.WriteLine("Тип double:");
            double e = 12312312313;
            Console.WriteLine(e);
            Console.WriteLine("Тип float:");
            float f = 12313.22F;
            Console.WriteLine(f);
            Console.WriteLine("Тип int:");
            int g = 1;
            Console.WriteLine(g);
            Console.WriteLine("Тип uint");
            uint a1 = 43023421;
            Console.WriteLine(a1);
            Console.WriteLine("Тип long:");
            long a2 = -213123123;
            Console.WriteLine(a2);
            Console.WriteLine("Тип ulong");
            ulong a3 = 123123;
            Console.WriteLine(a3);
            Console.WriteLine("Тип short");
            short a4 = 3212;
            Console.WriteLine(a4);
            Console.WriteLine("Тип ushort:");
            ushort b1 = 2313;
            Console.WriteLine(b1);

            //Не явное преоброзование
            int a11 = 111111111;
            long b11 = a11;

            byte a22 = 22;
            ushort b22 = a22;

            uint a33 = 2323233;
            ulong b33 = a33;

            sbyte a44 = 127;
            short b44 = a44;

            //Явное преоброзование 
            Console.WriteLine("Явное преобразование:");
            double x = 1234.7;
            Console.WriteLine("До " + x);
            int a55;
            a55 = (int)x;
            Console.WriteLine("После " + a55);

            //Упаковка и распоковка 
            int price = 10;
            object obj = price;

            int price2 = (int)obj;

            //Неявно типизорованая переменная
            for (var i = 0; i<10; i++)
            {
                string b66 = DateTime.Now.ToString();
                Console.WriteLine(b66);
            }

            //работа с null
            int? c66 = 7;
            if (c66 != null)
            {
                Console.WriteLine($"c is {c66.Value}");
            }
            else
            {
                Console.WriteLine("c does not have a value");
            }
            //????????????????????????????????
            var aa = 10000;
            int bb = aa;
            //????????????????????????????????
        }
        static void func2(string[] args)
        {
           //сравнение строк
            Console.WriteLine("Введите первую строку: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string s2 = Console.ReadLine();
            Console.WriteLine("Результат сравнения:" + (s1 == s2));

            //приколы над строками
            string line1 = "Первая строка";
            string line2 = "Вторая строка";
            string line3 = "Третья строка";
            Console.WriteLine("Конкантинация:" + (line1 + line2 + line3));
            Console.WriteLine("Выделение подстроки:" + (line1.Substring(2, 5)));
            string[] words = line1.Split(' ');
            Console.WriteLine("Певрое слово:" + words[0]);
            Console.WriteLine("Второе слово:" + words[1]);
            string modif = line2.Insert(2, line1);
            Console.WriteLine("После вставки подстроки: " + modif);
            var user = new
            {
                Name = "John Doe",
                Age = 42
            };
            Console.WriteLine($"{user.Name} is {user.Age} years old");

            //Создайте пустую и nullстроку. Продемонстрируйте использование метода string.IsNullOrEmpty. Продемонстрируйте что еще можно выполнить с такими строками


        }
    }
}
