

using System;

namespace Practice.Chapter3.Attribute
{
    class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "Kora";
            person.SecondName = "Lis";
            Console.WriteLine(person.FullName);
            
            Console.ReadKey();
        }
    }

    class Person
    {
        private string fullName;

        public string FullName
        {
            get { return $"{firstName} {secondName}"; }
            //set { fullName = value; }
        }

        private string firstName;
        public string FirstName
        {
            //get { return firstName; }
            set { firstName = value; }
        }

        private string secondName;
        public string SecondName
        {
           // get { return secondName; }
            set { secondName = value; }
        }
    }
}


/*using System;                 // повтор пройденной темы, самостоятельная работа

namespace Practice.Chapter3.Attribute
{
    class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Name);
            person.Age = 34;
            person.Age = -2;
            //person.Age = 23;
            Console.WriteLine(person.Age);

            Console.ReadKey();
        }
    }

    class Person
    {
        private string name;
        public string Name { get; set; } = "Kot";
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 30)
                {
                    age = value;
                }
            }
        }
    }
}*/

/*using System;

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
}*/

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
