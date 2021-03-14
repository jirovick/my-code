using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[12];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 12);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int min = array[0];
            for (int i = 0; i < 12; i++)

            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            int max = array[11];
            for (int i = 0; i < 12; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine("минимальное {0}", min);
            Console.WriteLine("максимальное {0}", max);
            Console.Read();
        }
    }
}