using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVariables
{
    class Program
    {
        static void Main()
        {

            /*
            string greeting = "Hello, user! The game's start condition is: ";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);

            gameStarted = true;
            //displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);
            Console.ReadKey();
            */
            string name = "  Steve                 ";
            int health = 10;
            int armor = 2;
            int strength = 5;
            Console.WriteLine($"Player {name.TrimStart().TrimEnd()} with {health} health, {armor} armor, and {strength} strength.");
            Console.WriteLine("Now say \"hi\"");
            string input = Console.ReadLine();
            if (input == "hi")
            {
                Console.WriteLine("Good job");
            }
            else 
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("You fail");
                }
            }
            Console.ReadLine();

        }
    }
}
