using System;

namespace dlya_rema
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int number = 0;
            Console.WriteLine("длина массива");
            int massLength = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[massLength];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
                if (mass[i] == 5)
                {
                    count++;
                }
            }


            Console.WriteLine("количество {0}", count);
           
        }
    }
}