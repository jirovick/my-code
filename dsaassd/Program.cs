using System;

namespace dsaassd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину массива");
            int length = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] mass = new int[length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 100);
                Console.Write(mass[i] + " ");
            }

            int half = length / 2;
            int temp = 0;
            for (int i = 0; i < mass.Length - half; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
            for (int i = 0; i < mass.Length - half - 1; i++)
            {
                for (int j = i + 1; j < mass.Length - 1; j++)
                {
                    if (mass[j] > mass[i])
                    {
                        temp = mass[j];
                        mass[j] = mass[i];
                        mass[j] = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }

            Console.ReadLine();
        }
    }
}