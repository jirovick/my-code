using System;
using задание_2;

public class Program
{
    public static void Main()
    {
        double a;
        double b;
        double end;
        char oper;

        Console.WriteLine("Введите первое число:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите оператор:");
        oper = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        b = Convert.ToDouble(Console.ReadLine());
        switch (oper)
        {
            case '+':
                end = Calculator.CountPlus(a, b);
                Console.WriteLine(end);
                break;
            case '-':
                end = Calculator.CountMinus(a, b);
                Console.WriteLine(end);
                break;
            case '*':
                end = Calculator.CountTimes(a, b);
                Console.WriteLine(end);
                break;
            case '/':
                if (b == 0)
                {
                    Console.WriteLine("на нуль делить нельзя дуралей");
                }
                else
                {
                    end = Calculator.CountDiv(a, b);
                    Console.WriteLine(end);
                }
                break;
        }

    }
   
    
}