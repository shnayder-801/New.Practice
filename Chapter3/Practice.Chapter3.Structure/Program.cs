using System;

namespace Practice.Chapter3.Structure               //решение (в) задачи № 2
{
    struct Person
    {
        public string name;
        public int age;

        public Person(string n, int a)
        {
            name = n;
            age = a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            person.name = "Bob";
            person.age = 32;

            Console.WriteLine($"{person.name} {person.age}");
            Console.ReadKey();
        }
    }
}

/*                                //решение (а) задачи № 2
    struct Person
    {
        public string name;
        public int age;
        public Person(string n, int a)
        {
            name = n;
            age = a;
        }

            public void Get()
            {
            Console.WriteLine($"{name} - {age}");
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
            Person person = new Person("Bob", 43);
            person.Get();

            Console.ReadKey();
        }
    }
}
*/

/*                                         //условие задачи № 2
    struct Person                             
    {
        public string name;
        public int age;
        public Person(string n)
        {
            name = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            person.name = "Bob";
        }
    }
    */

/*                                          //решение (в) задачи № 1
    struct Person                              
    {
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            person.name = "Bob";

            Console.WriteLine(person.name);
            Console.ReadKey();
        }
    }
 }
 */

/*                                            //решение (а) задачи № 1
     public struct Person
    {
        public string name;

        public Person(string b) { name = b; }

        public void Get()
        {
            Console.WriteLine($"{name}");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Person person=new Person();
            person.name = "Bob";
            person.Get();
           
            Console.ReadKey();
        }
    }
}
*/

/*                                           // условие задачи № 1
struct Person
{
    public string name;
}
class Program
{
    static void Main(string[] args)
    {
        Person person;
        Console.WriteLine(person.name);
        person.name = "Bob";
    }
}*/
