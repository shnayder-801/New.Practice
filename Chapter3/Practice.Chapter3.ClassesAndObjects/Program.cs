using System;

namespace Practice.Chapter3.ClassesAndObjects
{
    internal class Date
    {
        public string name;
        public string surname;
        public int age;
        public double weight;
        public double height;

        public Date() : this(name:"Леонид", surname:"Тархан")
        {
        }
        public Date(string name, string surname) : this(surname, age:41)
        {
        }
        public Date(string surname, int age) : this(age, age)
        {
        }
        public Date(int age, double weight) : this(weight, weight)
        {
        }
        public Date(double weight, double height) 
        {
        }

        public void GetConditions()
        {
            Console.WriteLine("Введите анкетные данные:");
            Console.WriteLine($"Имя:{name} \nФамилия:{surname} \nВозраст:{age} \nВес:{weight} \nРост:{height} ");
        }

    class Program
    {
    }
        private static void Main(string[] args)
        {
            Date a = new Date { name = "Леонид", surname = "Тархан", age = 41, weight = 74.5, height = 176.8};
            
            a.GetConditions();
            Console.ReadKey();
        }
    }
}



    /*class Date
    {
        public string name;
        public string surname;
        public int age;
        public double weight;
        public double height;

        public Date(string a, string b, int c, double z, double x) { name=a; surname=b; age=c; weight = z; height = x; }
        
        public void GetConditions()
        {
            Console.WriteLine("Введите анкетные данные:");
            Console.WriteLine($"Имя:{name} \nФамилия:{surname} \nВозраст:{age} \nВес:{weight} \nРост:{height} ");
        }

        class Program
        {
        }

        static void Main(string[] args)
        {
           Date a = new Date("Леонид", "Тархан", 41, 74.5, 176.8); 
           
           a.GetConditions();
           Console.ReadKey();
        }
    }
}*/

/*class Person
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
            Console.WriteLine("Введите Ваши данные: ");

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
}*/



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

