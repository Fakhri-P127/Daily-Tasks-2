using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Operator(+,-,/,*): ");
            string operators = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            switch (operators)
            {
                case "+":
                    {
                        Console.WriteLine("Result: " + Add(number1, number2));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("Result: " + Subtract(number1, number2));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("Result: " + Divide(number1, number2));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("Result: " + Multiply(number1, number2));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Operator (\"+, -, /, *\") must be one of these");
                        break;
                    }
            }
            #region If ile
            //if(operators == "+")
            //{              
            //    Console.WriteLine("Result: "+ Add(number1, number2));
            //}
            //else if(operators == "-")
            //{
            //    Console.WriteLine("Result: " + Subtract(number1, number2));
            //}
            //else if (operators == "/")
            //{
            //    Console.WriteLine("Result: " + Divide(number1, number2));
            //}
            //else if (operators == "*")
            //{
            //    Console.WriteLine("Result: " + Multiply(number1, number2));
            //}
            //else
            //{
            //    Console.WriteLine("Operator (\"+, -, /, *\") must be one of these");
            //}
            #endregion
        }
        public static double Add(double num1, double num2)
        {
            num1 = num1 + num2;
            return num1;
        }
        public static double Subtract(double num1, double num2)
        {
            num1 = num1 - num2;
            return num1;
        }
        public static double Divide(double num1, double num2)
        {
            num1 = num1 / num2;
            return num1;
        }
        public static double Multiply(double num1, double num2)
        {
            num1 = num1 * num2;
            return num1;
        }
    }
}

