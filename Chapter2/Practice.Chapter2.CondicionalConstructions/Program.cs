using System;

namespace Practice.Chapter2.CondicionalConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 6;
            int x = 5;
            Console.WriteLine("Нажмите + или -");
            string selected = Console.ReadLine();

            int z = selected == "+"?(x + y):(x - y);
            Console.WriteLine(z);
            Console.ReadKey();
            
            /*
            int i = 30;
            switch (i)
            {
                case 10:
                    Console.WriteLine("case 10");
                    goto case 20;
                case 20:
                    Console.WriteLine("case 20");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
                        Console.ReadKey();
                        */
            /*
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
            */
        }
    }
}
