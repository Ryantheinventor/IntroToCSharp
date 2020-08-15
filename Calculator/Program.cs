using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            float lastResult = 0;
            bool ranOnce = false;
            bool mainLoop = true;
            while (mainLoop) 
            {
                
                //pick action to be performed or exit
                char actionType = 'a';
                Console.WriteLine("What action would you like to perform.\n(A)dd,(S)ubtract,(M)ultiply,(D)ivide,(E)xit");
                while (true) 
                {
                    string input = Console.ReadLine().ToLower();
                    if (input.StartsWith("a"))
                    {
                        actionType = '+';
                        break;
                    }
                    else if (input.StartsWith("s"))
                    {
                        actionType = '-';
                        break;
                    }
                    else if (input.StartsWith("m"))
                    {
                        actionType = '*';
                        break;
                    }
                    else if (input.StartsWith("d"))
                    {
                        actionType = '/';
                        break;
                    }
                    else if (input.StartsWith("e"))
                    {
                        mainLoop = false;
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Invalid response...");
                    }
                }
                //exit main loop if exit was chosen
                if (!mainLoop) 
                {
                    break;
                }

                float num1 = 0;
                float num2 = 0;
                //if a problem has been solved already the user will be prompted on if they would like to use the previous result
                if (ranOnce)
                {
                    Console.WriteLine("Carry over last result? y/n");
                    while (true) 
                    {
                        string input = Console.ReadLine().ToLower();
                        if (input.StartsWith("y"))
                        {
                            num1 = lastResult;
                            break;
                        }
                        else if (input.StartsWith("n"))
                        {
                            num1 = GetNumber("Enter the first number.");
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Invalid response...");
                        }
                    }
                    
                }
                else 
                {
                    num1 = GetNumber("Enter the first number.");
                }
                Console.WriteLine($"{num1}{actionType}");
                while (true)
                {
                    num2 = GetNumber("Enter the second number.");
                    if (num2 == 0 && actionType == '/')
                    {
                        Console.WriteLine("Can't divide by \"0\"");
                    }
                    else 
                    {
                        break;
                    }
                }

                float result = 0;
                switch (actionType) 
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine($"{num1}{actionType}{num2}={result}");
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine($"{num1}{actionType}{num2}={result}");
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine($"{num1}{actionType}{num2}={result}");
                        break;
                    case '/':
                        result = num1 / num2;
                        Console.WriteLine($"{num1}{actionType}{num2}={result}");
                        break;
                }
                lastResult = result;
                ranOnce = true;
            }


        }


        static float GetNumber(string prompt) 
        {

            Console.WriteLine(prompt);
            while (true) 
            {
                float number = 0f;
                if (float.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                else 
                {
                    Console.WriteLine("Sorry that was not the correct format. Please try again");
                }
                
            }
        }
    }
}
