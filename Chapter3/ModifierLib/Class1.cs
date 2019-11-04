using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifierLib
{
    public class User
    {
        protected internal string name = "Lim";         
        protected int age = 41;            
        
        public void Display()
        {
            Console.WriteLine($"{name}");
        }

        class Employer : User
        {
            public void DisplayEmployer()                        //можем использовать переменные с модификатором protected из класса User
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
