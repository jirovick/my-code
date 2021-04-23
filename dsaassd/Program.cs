using System;

namespace dsaassd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите длину массива");
            int length = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("введите минимальное число");
            int min = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("введите максимальное число");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] mass = ArrayHelper.CreateRandom(length, min, max);
            
            Console.WriteLine("Сгенерированный массив");
            ArrayHelper.ArrayWrite(mass);
            
            int[] sortedArray = ArrayHelper.SortAsc(mass, 0, mass.Length / 2);
            sortedArray = ArrayHelper.SortDesc(sortedArray, sortedArray.Length / 2, sortedArray.Length);
            
            Console.WriteLine("Вывод отсортированного массива");
            ArrayHelper.ArrayWrite(sortedArray);
            Console.ReadLine();
            
        }
        
        
    }
}