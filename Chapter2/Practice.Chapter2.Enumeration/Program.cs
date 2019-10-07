using System;
using System.Diagnostics;

namespace Practice.Chapter2.Enumeration
{
    class Program
    {
        enum Colore : int
        {
            Red,
            Green,
            Brown,
            Black
        }

        static void ColoreSum(int x, int y, Colore lo)
        {
            var result = 0;

            switch (lo)
            {
                case Colore.Black:
                    result = x + y;
                    break;
                case Colore.Brown:
                    result = x - y;
                    break;
                case Colore.Green:
                    result = x * y;
                    break;
                case Colore.Red:
                    result = x / y;
                    break;
            }

            Console.WriteLine("Результатом операции является {0}", +result);
        }

        private static void Main(string[] args)
        {
            ColoreSum(25, 30, Colore.Black);
            ColoreSum(35, 65, Colore.Black);
            ColoreSum(56, 24, Colore.Green);
            ColoreSum(80, 20, Colore.Red);

            Console.ReadKey();
        }
    }
}

/*enum Tasck : byte
    {
        Work =  2,
        Relax = 3,
        Sleep = 4,
        Sport = 6
        }
    class Program
    {
        static void Jack(byte x, byte y, Tasck low)
        {
            byte result = 0;

            switch (low)
            {
                case Tasck.Sport:
                    result = (byte) (x + y);
                    break;
                case Tasck.Relax:
                    result = (byte) (x - y);
                    break;
                case Tasck.Sleep:
                    result = (byte) (x * y);
                    break;
                case Tasck.Work:
                    result = (byte) (x / y);
                    break;
            }

            Console.WriteLine("Результат операции равен {0}", + result);
            }

        static void Main(string[] args)
        {
            Jack(10, 15, Tasck.Sleep);
            Jack(20, 15, Tasck.Work);

            Console.ReadLine();
        }
    }
}*/
