using System;

namespace dsaassd
{
    public class ArrayHelper
    {
        /// <summary>
        /// сортировка по возрастанию
        /// </summary>
        /// <param name="array">сортируемый массив</param>
        /// <param name="start">начало</param>
        /// <param name="end">конец</param>
        /// <returns></returns>
        public static int[] SortAsc(int[] array, int start, int end)
        {
            int temp = 0;
            for (int i = start; i < end; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// сортировка по убыванию
        /// </summary>
        /// <param name="array">сортируемый массив</param>
        /// <param name="start">начало</param>
        /// <param name="end">конец</param>
        /// <returns></returns>
        public static int[] SortDesc(int[] array, int start, int end)
        {
            int temp = 0;
            for (int i = start; i < end; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[j] = array[i];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// заполнение массива рандомными числами
        /// </summary>
        /// <param name="length">длина массива</param>
        /// <param name="minValue">минимальное значение</param>
        /// <param name="maxValue">максимальное значение</param>
        /// <returns></returns>
        public static int[] CreateRandom(int length, int minValue, int maxValue)
        {
            Random rnd = new Random();
            int[] randomArray = new int[length];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(minValue, maxValue);
            }

            return randomArray;
        }

        /// <summary>
        /// выводим массив
        /// </summary>
        /// <param name="array">массив</param>
        public static void ArrayWrite(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}