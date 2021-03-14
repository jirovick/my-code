using System;

namespace task_4_pedik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину массива");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[k];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            double sum = 0;
            for (int j = 0; j < mas.Length; j++)
            {
                sum += mas[j];
            }

            double mid = sum / mas.Length;
            Console.WriteLine("отвит");
            Console.WriteLine(mid);
            Console.ReadKey();
        }
    }
}