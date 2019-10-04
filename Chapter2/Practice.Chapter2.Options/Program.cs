using System;

namespace Practice.Chapter2.Options
{
    class Program
    {
        static void Leg(params int[] org)                          // требует дополнительной проработки (многое не понятно!!!!!)
        {
            int num = 0;
            for (int i = 0; i < org.Length; i++)
            {
                num += org[i];
            }
            Console.WriteLine();
            }
        static void LegMas(int[] org, int k)
            {
                int num = 0;
                for (int i = 0; i < org.Length; i++)
                {
                    num += (org[i] * k);
                }
                Console.WriteLine();
            }
            static void Main(string[] args)
            {
                Leg(1, 2, 3, 4, 5);

                int[] org = new int[] {1, 2, 3, 4, 5};

                LegMas(org, 2);

                Console.ReadLine();
            }
        }
    }



/* static void Leg(params int [] org)
 {
     int num = 0;
     for (int i = 0; i < org.Length; i++)
     {
         num += org[i];
     }

     Console.WriteLine(num);
 }

 static void Main(string[] args)
 {
     Leg(1, 2, 3, 4, 5);

     int[] org = new int[] {1, 2, 3, 4};
     Leg(org);
     Leg();
     Console.ReadLine();
 }
}
}*/            //требует дополнительной проработки (сложно воспринимается !!!!)

/*static void Main(string[] args)
{
    int a = 10;
    int area;
    int perim;
    GetDate(a, 15, out area, out perim);
    Console.WriteLine("Площадь: " + area);
    Console.WriteLine("Периметр: " + perim);
    Console.ReadKey();
}

private static void GetDate(int x, int y, out int area, out int perim)
{
    area = x * y;
    perim = (x + y) * 2;
}
}
}*/

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


