using System;
using System.Net.Sockets;
using задание_2;

public class Program

{
    public static void Main()
    {
        double b = 0;
        double end = 0;
        Console.WriteLine("Введите первое число:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите оператор:");
        string oper = Console.ReadLine();

        if (oper == "+" || oper == "-" || oper == "/")
        {
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
        }

        Console.Write("Отвит:");
        end = Calculator.Execute(oper, a, b, end);
        Console.WriteLine(end);
        
    }
}