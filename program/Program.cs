using System;
using System.Collections.Generic;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Operation> operationsMap = CreateDictionary();
            double b = 0;
            double end = 0;
            
            Console.WriteLine("доступные операторы");
            foreach (var x in operationsMap.Keys)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Введите число:");
            double a = Convert.ToDouble(Console.ReadLine());
            
            while (true)
            {
                
                Console.WriteLine("Введите оператор:");
                string operString = Console.ReadLine();
                Operation operation = operationsMap[operString];
                if (operation.Operator == "tan" || operation.Operator == "cos")
                {
                    a = operation.Execute(a);
                }
                else
                {
                    Console.WriteLine("Введите другое число:");
                    b = Convert.ToDouble(Console.ReadLine());   
                    a = operation.Execute(a, b);
                }
                Console.Write("Отвит:");
                Console.WriteLine(a);
                
                
            }
        }

        static Dictionary<string, Operation> CreateDictionary()
        {
            var operationsMap = new Dictionary<string, Operation>();
            operationsMap["-"] = new MinusOperation();
            operationsMap["cos"] = new CosOperation();
            operationsMap["tan"] = new TanOperation();
            operationsMap["+"] = new PlusOperation();
            operationsMap["/"] = new DivOperation();
            operationsMap["*"] = new TimesOperation();
            

            return operationsMap;
        }
    }
}