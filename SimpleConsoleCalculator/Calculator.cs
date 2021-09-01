using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleCalculator
{
    public class Calculator
    {
        public double Calculate(double firstValue, string operation, double secondValue)
        {
            if (operation == "+")
            {
                return firstValue + secondValue;
            }
            if (operation == "-")
            {
                return firstValue - secondValue;
            }
            if (operation == "*")
            {
                return firstValue * secondValue;
            }
            if (operation == "/")
            {
                if (secondValue == 0)
                {
                    throw new DivideByZeroException("An error has been occured: Can not divide by zero!");
                }
                return firstValue / secondValue;
            }
            else
            {
                Console.WriteLine("An error has been occured: inapplicable operator");
                Console.WriteLine("Please enter one of these operators: '+', '-', '*', '/'");

                operation = Console.ReadLine();

                if (operation == "+")
                {
                    return firstValue + secondValue;
                }
                if (operation == "-")
                {
                    return firstValue - secondValue;
                }
                if (operation == "*")
                {
                    return firstValue * secondValue;
                }
                if (operation == "/")
                {
                    if (secondValue == 0)
                    {
                        throw new DivideByZeroException("An error has been occured: Can not divide by zero!");
                    }
                    return firstValue / secondValue;
                }
            }
            return firstValue;
        }
    }
}
