using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(0);
        }
        private static void Calculate(double startNumber)
        {
            bool keepAlive = true;
            while (keepAlive)
            {
                try 
                {
                    double firstNumber;
                    if (startNumber == 0)
                    {
                        Console.WriteLine("Enter a Number: ");
                        firstNumber = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        firstNumber = startNumber;
                        Console.WriteLine(firstNumber);
                    }
                    Console.WriteLine("Chose between +, -, /, * or C to clear");
                    string userInput = Console.ReadLine();
                    Console.WriteLine("Add another number");
                    double secondNumber = double.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (userInput)
                    {
                        case "+":
                            firstNumber = CalcAdd(firstNumber, secondNumber);
                            Console.WriteLine(firstNumber);
                            break;

                        case "-":
                            firstNumber = CalcSub(firstNumber, secondNumber);
                            Console.WriteLine(firstNumber);
                            break;

                        case "/":
                            if (secondNumber != 0)
                            {
                                firstNumber = CalcDiv(firstNumber, secondNumber);
                                Console.WriteLine(firstNumber);
                            }
                            else
                            {
                                Console.WriteLine("Cannot divide by 0");
                                CalcClear(firstNumber);
                            }
                            break;

                        case "*":
                            firstNumber = CalcMulti(firstNumber, secondNumber);
                            Console.WriteLine(firstNumber);
                            break;

                        case "C":
                            Console.WriteLine("Clearing");
                            CalcClear(0);
                            break;

                        default:
                            Console.WriteLine("That is not an option");
                            CalcClear(firstNumber);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("CATCH!! That is not an option");
                }
            }
        }
        static double CalcAdd(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static double CalcSub(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        static double CalcDiv(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
        static double CalcMulti(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        static void CalcClear(double number)
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Calculate(number);
        }
    }
}
