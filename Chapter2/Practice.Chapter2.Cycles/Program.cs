using System;

namespace Practice.Chapter2.Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 6;
            while (i>5)
            {
                Console.WriteLine(i);
                i++;
                Console.ReadKey();
            }
            /*
            int i = 46;
            do
            {
               Console.WriteLine(i);
                i++;
            }
            while (i<100);
            Console.ReadKey();
            */

            /*
             for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Квадрат числа {i} равен {i * i}");
                Console.ReadKey();
                */
        }
    }
}
