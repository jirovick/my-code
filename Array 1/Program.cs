using System;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                a[i] = b;
            }
            // WriteArray(a);
            // Console.WriteLine("----------------");
            // int c = 0;
            // for (int i = 0; i < a.Length; i++)
            // {
            //     c = c + a[i];
            //     
            // }
            // Console.WriteLine(c);
            //
            // Console.WriteLine("----------------");
            // int min = 0;
            // for (int i = 0; i < a.Length - 1; i++)
            // {
            //     for (int j = i + 1; j < a.Length; j++)
            //     {
            //         if (a[i] > a[j])
            //         {
            //             min = a[i];
            //             a[i] = a[j];
            //             a[j] = min;
            //         }
            //     }
            // }
            WriteArray(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            int z = 10;
            WriteVar(z);
            Console.WriteLine("Результат перменной z = {0}",z);
            Math.Cos(z);
            a.
            

        }

        static void WriteVar(int w)
        {
            Console.WriteLine("резульятат в методу w = {0}", w);
            w = 5;
        }
        

        static void WriteArray(int[] array)
        {
            
            Console.WriteLine("----------------");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 5;
            }
            
        }   
        
    }
}