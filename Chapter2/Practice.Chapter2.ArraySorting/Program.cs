using System;

namespace Practice.Chapter2.ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[7];
            Console.WriteLine("Введите семь чисел: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0}-e число: ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива: ");
            for (int i = 0; i < nums.Length; i++)
            {
               Console.WriteLine(nums[i]); 
            }
            Console.ReadKey();
                }
            }
        }
    