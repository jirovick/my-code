using System;

namespace задание_2
{
    public class Calculator
    {
        /// <summary>
        /// суммирует числа
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <param name="number2">второе число</param>
        /// <returns></returns>
        public static double CountPlus(double number1, double number2)
        {
            double resault;
            resault = number1 + number2;
            return resault;
        }

        /// <summary>
        /// вычитает числа
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <param name="number2">второе число</param>
        /// <returns></returns>
        public static double CountMinus(double number1, double number2)
        {
            double resault;
            resault = number1 - number2;
            return resault;
        }

        /// <summary>
        /// умножает числа
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <param name="number2">второе число</param>
        /// <returns></returns>
        public static double CountTimes(double number1, double number2)
        {
            double resault;
            resault = number1 * number2;
            return resault;
        }

        /// <summary>
        /// делит числа
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <param name="number2">второе число</param>
        /// <returns></returns>
        public static double CountDiv(double number1, double number2)
        {
            double resault;
            resault = number1 / number2;
            return resault;
        }

        /// <summary>
        /// находит тангенс угла
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <returns></returns>
        public static double CountTan(double number1)
        {
            double resault;
            resault = Math.Tan(number1);
            return resault;
        }

        /// <summary>
        /// находит косинус угла
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <returns></returns>
        public static double CountCos(double number1)
        {
            double resault;
            resault = Math.Cos(number1);
            return resault;
        }

        /// <summary>
        /// находит синус угла
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <returns></returns>
        public static double CountSin(double number1)
        {
            double resault;
            resault = Math.Sin(number1);
            return resault;
        }

        public static double Execute(string operation, double number1, double number2, double resault)
        {
            switch (operation)
            {
                case "+":
                    resault = CountPlus(number1, number2);
                    break;
                case "-":
                    resault = CountMinus(number1, number2);

                    break;
                case "*":
                    resault = CountTimes(number1, number2);

                    break;
                case "/":
                    if (number2 == 0)
                    {
                        resault = 0;
                    }
                    else
                    {
                        resault = CountDiv(number1, number2);
                    }

                    break;
                case "tn":
                    resault = CountTan(number2);

                    break;
                case "sin":
                    resault = CountSin(number2);

                    break;
                case "cos":
                    resault = CountCos(number2);

                    break;
                case "log":
                    resault = Math.Log10(number1);
                    break;
            }

            return resault;
        }
    }
}