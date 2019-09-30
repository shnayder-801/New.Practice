using System;


namespace Practice.Chapter2.Conversion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост: ");
            var hight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите размер заработной платы: ");
            var salory = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Имя:{name}, Возраст:{age} лет, Рост: {hight} метров, Заработная плата: {salory}$");
            Console.ReadKey();

            /*
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост: ");
            double hight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите размер заработной платы: ");
            double salory = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Имя:{name}, Возраст:{age} лет, Рост: {hight} метров, Заработная плата: {salory}$");
            Console.ReadKey();
            */
        }
    }
}
