using System;

namespace Practice.Chapter3.ClassesAndObjects
{
    class Person
    {
        public string name;
        public int age;

        public Person() : this("Неизвестно")
        {
        }
        public Person(string name) : this(name, 41)
        {
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name} Возраст: {age}");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Person leo = new Person {name = "leo", age = 43};
                Person noy = new Person {name = "noy", age = 44};
                Person loy = new Person {name = "loy", age = 45};

                leo.GetInfo();
                noy.GetInfo();
                loy.GetInfo();

                Console.ReadKey();
            }
        }
    }
}



/*public string name;
public int age;

public Person() { name = "Неизвестно"; age = 41; }
public Person(string n) { name = n; age = 41; }
public Person(string n, int a) { name = n; age = a; }

public void GetInfo()
{
    Console.WriteLine($"Имя: {name} Возраст: {age}");
}

class Program
{
    static void Main(string[] args)
    {
        Person leo = new Person();
        Person noy = new Person("noy");
        Person loy = new Person("loy");

        leo.GetInfo();
        noy.GetInfo();
        loy.GetInfo();

        Console.ReadKey();
    }
}
}
}*/




/*class Person
{
    public string name;
    public int age;

    public void GetInfo()
    {
      Console.WriteLine($"Имя: {name} Возраст: {age}");
       }

    class Program
    {
        static void Main(string[] args)
        {
            Person leonid = new Person();
            leonid.GetInfo();                          

            leonid.name = "Leo";
            leonid.age = 41;
            leonid.GetInfo();

            Console.Read();
        }
    }
}
}*/

