using System;

namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите блюдо");
            string eat = Console.ReadLine();
            Console.WriteLine("введите калории");
            int calories = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Блюдо: {eat} Калории: {calories}");
        }
    }
}