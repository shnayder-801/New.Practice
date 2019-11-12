using System;

namespace Practice.Chapter3.MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate raf = new Calculate();
            raf.Cal(4, 5);
            raf.Cal(234, 25, 45);
            raf.Cal(234, 25, 4.4);
            Console.ReadKey();
        }
    }
    class Calculate
        {
            public void Cal(int x, int y)
            {
                int result = x + y;
                Console.WriteLine($"Result is: {result}");
            }
            public void Cal(int x, int y, int b)
                {
                    int result = x + y - b;
                    Console.WriteLine($"Result is: {result}");
            }
            public void Cal(int x, int y, double b)
            {
                double result = x + y - b;
                Console.WriteLine($"Result is: {result}");
        }
    }
}
