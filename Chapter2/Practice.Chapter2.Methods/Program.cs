using System;

namespace Practice.Chapter2.Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bet = Get();
            var vet = SutA();

            Console.WriteLine(bet);
            Console.WriteLine(vet);
            Console.ReadKey();
        }

        private static string Get()
        {
            return "Super";
        }

        private static int SutA()
        {
            var x = 32;
            var c = 21;
            var z = x - c;
            return z;
        }
    }
}


/*string bet = GetHello();
int red = GetSum();

Console.WriteLine(bet);
Console.WriteLine(red);
Console.ReadKey();
}

private static string GetHello()
{

return "Hello";
}

static int GetSum()
{
int x = 5;
int c = 9;
int z = x + c;

return z;
}
}
}*/

/*
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();
            Console.ReadKey();
        }

        private static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        private static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
            */
      