using System;

namespace Practice.Chapter2.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Вашу фамилию: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Введите Ваше имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Место работы: ");
            var employed = Console.ReadLine();
            Console.WriteLine("Ваш возраст: ");
            var age = Console.ReadLine();
            Console.WriteLine("Ваше семейное положение: ");
            var family = Console.ReadLine();

            Console.WriteLine($"\tФамилия: {surname} \n\tИмя: {name} \n\tМесто работы: {employed} \n\tВозраст: {age} \n\tСемейное положение: {family}");
            Console.ReadKey();

            /*
            var variable = "Вероятность не менее ";
            var a = 40;
            Console.WriteLine(a.GetType().ToString());
            Console.WriteLine(variable.GetType().ToString());
            Console.ReadKey();
            */
            /*
            string name = "Леонид";
            int age = 41;
            double weight= 75.3;
            bool employed = false;

            Console.WriteLine($"Имя: {name} ");
            Console.WriteLine($"Возраст: {age} ");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {employed}");
            Console.ReadKey();*
            */
            /*
            string name = "Tom";
            Console.WriteLine(name);
            name = "Bob";
            Console.WriteLine(name);
            Console.ReadKey();
            */
        }
    }
}
