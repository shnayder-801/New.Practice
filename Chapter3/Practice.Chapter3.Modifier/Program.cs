using System;
using ModifierLib;

namespace Practice.Chapter3.Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
           //Person person = new Person();
           // person.name = "Leo";
           //person.Display();

            Manager manager = new Manager();           //использовали модификатор protected для переменной в библиотеке класса ModifierLib
            manager.DisplayManager();

           // User user = new User();              
            Console.ReadKey();
        }
    }
    class Manager : User
        {
            public void DisplayManager()
            {
                Console.WriteLine($"{name} {age}");
            }
    }

    class Person
    {
        public string name;         // позволяет использовать в любом месте (в классе Program)
        private int age;            // только в текущем классе
                                    // по умолчанию всегда private

        public void Display()
        {
        Console.WriteLine($"{name}");
        }
    }
}
