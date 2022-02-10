using System;

namespace Task2_ferqli_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator(+, -, /, *) : ");
            string operators = Console.ReadLine();
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            switch (operators)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Operator \"+, -, *, /\" must be one of these");
                    break;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
