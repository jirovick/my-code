using System;

namespace task_1
{
    class Program
    {
        public static bool CheckNumber(int number)
        {
            int summ = 1;
            for (int i = 2; i < number / 2 + 1; i++)
                if (number % i == 0)
                    summ += i;
            return (summ == number);
        }

        static void Main(string[] args)
        {
            int number = 0;

            Console.WriteLine("Введите число");
            number = Convert.ToInt32(Console.ReadLine());

            if (CheckNumber(number))
            {
                Console.WriteLine("Совершенное");
            }
            else Console.WriteLine("Не совершенное");
            Console.ReadKey();
        }
    }
}