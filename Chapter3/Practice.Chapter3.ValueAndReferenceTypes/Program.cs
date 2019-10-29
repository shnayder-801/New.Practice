using System;


namespace Practice.Chapter3.ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1= new User {name = "Tom", age = 22};
            ChangeUser(user1);
            Console.WriteLine($"{user1.name} - {user1.age}");

            Console.ReadKey();
        }

        static void ChangeUser(User user)
            {
                user.name = "Bob";
                user.age = 33;
            }
        }

        struct User
      {
        public string name;
        public int age;
      }

     class Person
    {
        public string name;
        public int age;
    }
}




/*                                 //пример изменений при передачече значений объекта методу
    class Program
    {
        static void Main(string[] args)
        {
            Deal p = new Deal {name = "Bill", age = 23};
            Get(p);

            Console.WriteLine(p.name);
            Console.WriteLine(p.age);

            Console.Read();
            }

        public static void Get(Deal deal)
        {
            deal.name = "Alice";
            deal = new Deal {name = "Bob", age = 33};
            Console.WriteLine(deal.name);
        }
    }

    class Deal
        {
            public string name;
            public int age;
        }
    }
    */
