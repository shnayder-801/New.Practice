using System;


namespace Practice.Chapter2.Cortege
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = GetValue(new int[] {1, 2, 3, 4, 5});
            Console.WriteLine(tuple.sum);
            Console.WriteLine(tuple.count);
            Console.Read();
        }                                                                  /* не работает ?????? Предположительно в версии отсутствует 
                                                                              функция работы с кортежами */

        static (int sum, int count) GetValue(int[] numbers)
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }

            return result;
        }
    }
}


           /* var tuple =Hay(45, 4);
            Console.WriteLine(tuple);
            Console.WriteLine("{0}");

            Console.Read();
        }
        static int Hay(int x, int y)
        { 
            var result = x*y;
            return result;
        }
    }
}*/
