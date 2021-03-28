using System;
using задание_2;

public class Program
{
    public static void Main()
    {

        double end = 0;
        Console.WriteLine("Введите первое число:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите оператор:");
        string oper = Console.ReadLine();

        Console.WriteLine("Введите второе число:");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Отвит:");
        end = Execute.SwitchCase(oper, a, b, end);
        Console.WriteLine(end);


    }
    
   
   
    
}