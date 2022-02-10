using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

             if (number % 7 == 0 )
            {
                Console.WriteLine("7 ye bolunur");
            }
            else
            {
                Console.WriteLine("The Closest One Is: " + Nums(number,7)); 
            }
        }
        public static int Nums(int num1, int num2)
        {
            int smallNum = num1 - (num1 % num2);
            int bigNum = (num1 + num2) - (num1 % num2);

            if(num1-smallNum> bigNum - num1)
            {
                return bigNum;
            }
            else
            {
                return smallNum;
            }           
        }
    }
    
}
