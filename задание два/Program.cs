using System;
using System.Collections.Generic;

namespace задание_два
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину");
            Random rnd = new Random();
            List<double> lst = new List<double>();
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                int a = rnd.Next(-10, 30);
                lst.Add(a);
                Console.WriteLine(lst[i] + " ");
            }

            for (int i = 1; i < lst.Count; i++)
            {
                if (lst[i] <= 20 && lst[i] >= 10)
                {
                    lst.RemoveAt(i - 1);
                }
            }

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i] + " ");
            }
        }
    }
}