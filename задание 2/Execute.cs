using System;

namespace задание_2
{
    public class Execute
    {
        public static double SwitchCase(string operation, double number1, double number2, double resault)
        {
            switch (operation)
            {
                case "+":
                    resault = Calculator.CountPlus(number1, number2);
                    break;
                case "-":
                    resault = Calculator.CountMinus(number1, number2);
                    
                    break;
                case "*":
                    resault = Calculator.CountTimes(number1, number2);
                   
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        resault = 0;
                    }
                    else
                    {
                        resault = Calculator.CountDiv(number1, number2);
                       
                    }

                    break;
                case "tn":
                    resault = Calculator.CountTan(number2);
                    
                    break;
                case "sin":
                    resault = Calculator.CountSin(number2);
                    
                    break;
                case "cos":
                    resault = Calculator.CountCos(number2);
                    
                    break;
                case "log":
                    resault = Math.Log10(number1);
                    break;
                
            }

            return resault;
        }
    }
}