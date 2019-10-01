using System;

namespace Practice.Chapter.DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 12;
                byte c = checked((byte) (a + b));
                Console.WriteLine($"{c}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                /*
                byte a = 20;
                byte b = (byte) (a + 70);
                Console.WriteLine($"{b}");
                Console.ReadLine();
                */

            }
        }
    }
}
