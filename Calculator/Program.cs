using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(0);
        }

        static bool keepAlive = true;
        private static void Calculate(double firstNumber)
        {
            while (keepAlive)
            {
                try 
                {
                    Console.WriteLine("Calculator: press C to clear or E to exit");
                    if (firstNumber == 0)
                    {
                        Console.WriteLine("Type a number");
                        firstNumber = double.Parse(newInput());
                    }
                    else
                    {
                        Console.WriteLine(firstNumber);
                    }

                    Console.WriteLine("Type +, -, /, *");
                    string caseInput = newInput();
                    Console.WriteLine("Add another number");
                    double secondNumber = double.Parse(newInput());
                    Console.Clear();

                    switch (caseInput)
                    {
                        case "+":
                            firstNumber = CalcAdd(firstNumber, secondNumber);
                            break;

                        case "-":
                            firstNumber = CalcSub(firstNumber, secondNumber);
                            break;

                        case "/":
                            if (secondNumber != 0)
                            {
                                firstNumber = CalcDiv(firstNumber, secondNumber);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Cannot divide by 0");
                                CalcClear(firstNumber);
                            }
                            break;

                        case "*":
                            firstNumber = CalcMulti(firstNumber, secondNumber);
                            break;
                           
                        default:
                            Console.WriteLine("That is not an option");
                            CalcClear(firstNumber);
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("That is not an option");
                    CalcClear(firstNumber);
                }
            }
        }
        static string newInput()
        {
            string userInput = Console.ReadLine();
            if ((userInput == "C") || userInput == ("c"))
            {
                Console.Clear();
                Console.WriteLine("Clearing");
                keepAlive = false;
                CalcClear(0);
                return "";
            }
            else if ((userInput == "E") || (userInput == "e"))
            {
                Console.WriteLine("Exiting calculator");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
                return ("");
            }
            else
            {
                return userInput;
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
