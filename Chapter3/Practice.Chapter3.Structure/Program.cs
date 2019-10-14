using System;

namespace Practice.Chapter3.Structure
{
    struct User
    {
        public string name;
        public int age;

        public User(string n, int a)
        {
            name = n;
            age = a;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{name} - {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[2];
            users[0] = new User("Bob", 23);
            //users[0].age = 23;

            users[1].name = "Sam";
            users[1].age = 43;
            foreach (User User in users)
            {
                User.GetInfo();
            }
        
            User tom =new User("Tom", 33);
            //tom.name = "Tom";
            //tom.age = 33;

            tom.GetInfo();
            Console.ReadKey();
        }
    }
}
