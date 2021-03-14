using System;
using System.Data.Common;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dish = new string[2];
            for (int i = 0; i < dish.Length; i++)
            {
                Console.WriteLine("введите название блюда");

                dish[i] = Console.ReadLine();
            }

            Console.WriteLine("Ваши блюда:");
            for (int i = 0; i < dish.Length; i++)
            {
                Console.WriteLine(dish[i]);
            }
            Console.WriteLine("------------");


            int number = 0;
            for (int i = 0; i < dish.Length; i++) //перебирвет массив строк, введенных с клавиатуры
            {
                string a = dish[i];
                for (int j = 0; j < a.Length; j++) //ищет индекс цифры в строке, введенную с клавиатуры
                {
                    if (Char.IsNumber(a[j])) //определяет является ли сивол числом
                    {
                        string numberString = a.Substring(j);
                        number += Convert.ToInt32(numberString);
                        string words = a.Replace(numberString, "");

                        Console.WriteLine(words);
                        break;
                    }
                }
            }

            Console.WriteLine("сумма калорий");
            Console.WriteLine(number);
        }
    }
}