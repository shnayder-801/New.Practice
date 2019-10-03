using System;

namespace Practice.Chapter2.Options
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int area;
            int perim;
            GetDate(a, 15, out area, out perim);
            Console.WriteLine("Площадь: " +area);
            Console.WriteLine("Периметр: " +perim);
            Console.ReadKey();
        }

        static void GetDate(int x, int y, out int area, out int perim)
        {
            area = x * y;
            perim = (x + y) * 2;
        }
    }
}


        /*static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine($"Начальное значение переменной = {a}");
            Incremental(ref a);
            Console.WriteLine($"Переменная а после передачи по значению = {a}");
            Console.ReadLine();
        }

        private static void Incremental(ref int x)
        {
            x++;
            Console.WriteLine($"Incremental: {x}");
        }
    }
}*/


