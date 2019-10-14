using System;

namespace Practice.Chapter3.Structure
{
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
/*
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
