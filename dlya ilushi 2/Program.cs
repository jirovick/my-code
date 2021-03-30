using System;

namespace dlya_ilushi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите максимальную грузоподъемность");
            int weight = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] mass = new int[0];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(50, 500);
                Console.Write(mass[i] + " ");
            }
        }
    }
}