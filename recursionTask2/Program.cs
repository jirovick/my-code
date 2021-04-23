using System;

namespace recursionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите степень");
            int pow = Convert.ToInt32(Console.ReadLine());
            int end = CountPow(num, pow);
            Console.WriteLine("ответ");
            Console.WriteLine(end);
            Console.ReadKey();
            
        }

        static int CountPow(int number, int pow)
        {
            if (pow != 0)
            {
                return (number * CountPow(number, pow - 1));
            }
            else return 1;
        }
    }
}