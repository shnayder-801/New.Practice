//подключение классов из других пространств имен
using System;
using Practice.Chapter3.NameSpaces.Fridom;

namespace Practice.Chapter3.NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work(4);
        }

    }
    namespace Fridom
    {
        class Work
        {
            public int a { get; set; }
            public Work(int b)
            {
                a = b;
            }
        }
    }

}
