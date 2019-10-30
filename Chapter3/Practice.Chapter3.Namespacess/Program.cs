/*// условие задачи (создать объект класса Baz)

using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
namespace Foo
{
    namespace Boo
    {
        class Baz
        {

        }
    }
}*/

using System;
using Foo.Boo;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Baz baz= new Baz();
            baz.name = "Leonid";
            Console.WriteLine(baz.name);
            Console.ReadKey();
        }
    }
}
namespace Foo
{
    namespace Boo
    {
        class Baz
        {
            public string name;
        }
    }
}