using System;

namespace dlya_rema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            Console.WriteLine("введите максимальную грузоподъемность");
            int weight = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] mass = new int[30];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(50, 500);
                Console.Write(mass[i] + " ");
                summ += mass[i];
            }

            if (summ > weight)
            {
                Console.WriteLine("превышает");
            }
            else
            {
                Console.WriteLine("не превышает");
            }


            Console.WriteLine("Сумма=" + summ);
        }
    }
}