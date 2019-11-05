using System;

namespace Practice.Chapter3.Attribute
{
    class Program
    {
        private static void Main(string[] args)
        {
            Person person= new Person();
            person.First = "Los";
            Console.WriteLine(person.First);
            person.Age = 41;
            person.Age = -41;
            person.Age = 234;
            Console.WriteLine(person.Age);

            Console.ReadKey();
        }
    }
    class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value>=0 && value<50 )
                {
                    age = value;
                }
            }
        }
        private string first;
            public string First
            {
            get { return  first; }
            set { first = value; }
        }
    }
}

/*using System;

namespace Practice.Chapter3.Attribute
{
 class Person
        {
            public string Name { get; set; } = "Lis";
            public int Age { get; set; } = 23;
        }

    class Program
    {
        static void Main(string[] args)
        {
            Person person= new Person();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.ReadKey();
        }
    }
}*/
