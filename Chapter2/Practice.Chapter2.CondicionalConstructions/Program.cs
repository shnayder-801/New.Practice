using System;

namespace Practice.Chapter2.CondicionalConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите любую клавишу");
            var selection = Console.ReadLine();
            switch (selection)
            {
                case "a":
                    Console.WriteLine($"Вы нажали {selection}");
                    break;
                default:
                    Console.WriteLine($"Вы нажали {selection}");
                    break;
            }
            Console.ReadKey();
            }
    }
}
