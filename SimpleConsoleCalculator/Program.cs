using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SimpleConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture
                = new System.Globalization.CultureInfo("en-US");

            Calculator calculator = new Calculator();

            while (true)
            {
                Console.Clear();

                try
                {
                    while (true)
                    {
                        double firstValue;
                        double secondValue;
                        double result;

                        string operation;
                        string input;
                        string[] splitted;

                        input = Console.ReadLine();
                        splitted = input.Split(" ");

                        firstValue = double.Parse(splitted[0]);
                        operation = splitted[1];
                        secondValue = double.Parse(splitted[2]);

                        result = calculator.Calculate(firstValue, operation, secondValue);

                        Console.Write(result + " ");

                        while (true)
                        {
                            splitted = Console.ReadLine().Split(" ");

                            firstValue = result;
                            operation = splitted[0];
                            secondValue = double.Parse(splitted[1]);

                            result = calculator.Calculate(firstValue, operation, secondValue);
                            Console.Write(result + " ");
                        }
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("An error has been occured: Can not divide by zero!");
                    Console.WriteLine("Press \"enter\" to refresh");
                    Console.ReadLine();
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number");
                    Console.WriteLine("Press \"enter\" to refresh");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
