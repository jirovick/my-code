using System;

namespace dlya_ilushi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину массива");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[k];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }

            double sr = 0;
            double summ = 0;
            for (int j = 0; j < mass.Length; j++)
            {
                summ += mass[j];
                if (mass[j] > 0)
                {
                    sr = summ / mass.Length;
                }
            }
            Console.WriteLine("отвит");
            Console.WriteLine(sr);
            Console.ReadKey();
        }
    }
}