using System;

namespace Practice.Chapter2.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a= new int[10];
            for (int i = 0; i < a.Length; i++)
            {
             Console.WriteLine(i);
                Console.ReadKey();
            }

            /*
            int [] i = new int [4];
            foreach (var a in i)
            {
                Console.WriteLine(i);
                Console.ReadKey();
                */
            
            /*
            int [] i = new int [4];
            i [0] = 1;
            i [1] = 2;
            i [2] = 3;
            i [3] = 4;
            Console.WriteLine(i[2]);
            Console.ReadKey();
            */
        }
    }
}
