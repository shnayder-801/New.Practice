using System;

namespace Practice.Chapter2.ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 48;
            int z = 3;
            int c = b / ((a++) + z);
            Console.WriteLine($"b={b} a={a} z={z} c={c}");
            Console.ReadLine();
            /*
            int a = 6;
            int b = 48;
            int z = 3;
            int c = b / a++ + z;
            Console.WriteLine($"b={b} a={a} z={z} c={c}");
            Console.ReadLine();
            */
            /*
            int a1 = 12;
            int a2 = a1--;
            Console.WriteLine($"{a1}+{a2}={a1+a2}");
            Console.ReadLine();
            */
            /*
            double a = 35;
            double b = a/8;
            Console.WriteLine($"{b}");
            Console.ReadKey();
            */
            /*
            int a = 20;
            int z = a * 20;
            Console.WriteLine($"{z}");
            Console.ReadKey();
            */
        }
    }
}
