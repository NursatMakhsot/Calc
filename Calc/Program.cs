using System;

namespace Calc
{

    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if(num2 != 0)
                    {
                        
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("--------------------------");

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("Enter first number ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("It is not valid value. Enter correct number: ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Enter second number ");
                numInput1 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput1, out cleanNum2))
                {
                    Console.Write("It is not correct value. Enter correct number: ");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Choose the option");
                Console.WriteLine("\ta = Add");
                Console.WriteLine("\ts = Sub");
                Console.WriteLine("\tm = Multiply");
                Console.WriteLine("\td = Divide");

                Console.Write("Your option? >>> ");
                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine($"Result: {Math.Round(result, 3)}\n");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("-----------------------\n");

                Console.Write("Press 'e' and Enter to close app or Press another key and Enter to continue >>> ");

                if (Console.ReadLine().ToLower() == "e") endApp = true;

                Console.WriteLine("\n");

            }

            Console.WriteLine("Thanks for using calculator!");
            
            




        }
    }
}
