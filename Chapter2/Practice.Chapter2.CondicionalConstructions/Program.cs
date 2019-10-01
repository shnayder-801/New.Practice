using System;

namespace Practice.Chapter2.CondicionalConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите Y или N");
            var selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали Y");
                    break;
                case "N":
                    Console.WriteLine("Вы нажали N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }
            Console.ReadKey();
            /*
            var a = 12;
            var b = 12;
            if (a < b && a == 9)
            {
                Console.WriteLine($"Число {a} меньше числа {b}");
                }
                else if (a > b)
                {
                    Console.WriteLine($"Число {a} больше числа {b}");
                }
                else
                {
                    Console.WriteLine($"Число {a} равно числу {b}");
                }
                Console.ReadLine();
                */
        }
    }
}
