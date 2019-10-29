// импортирование свойств и методов классов
using System;
using static System.Console;
using static System.Math;                         //???????
using static Practice.Chapter3.NameSpaces.My;     //???????

namespace Practice.Chapter3.NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = 70;
            int year = My.MyI(weight);
            WriteLine(year);
            ReadKey();
        }
    }

        class My
        {
            public static int MyI(int weight)
            {
                return  weight / 5;
                }
            }
    }



/* //использование псевдонимов
using System;
using Dot = Practice.Chapter3.NameSpaces.User;
using Got= System.Console; 
namespace Practice.Chapter3.NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dot got = new Dot();
            got.name = "Noi";
            Got.WriteLine(got.name);
            Got.Read();
        }
    }

    class User
        {
            public string name;
    }
 }*/

/* //подключение классов из других пространств имен
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

}*/
