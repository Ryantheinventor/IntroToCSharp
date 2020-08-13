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
            string name = "Steve";
            int health = 10;
            int armor = 2;
            int strength = 5;
            Console.WriteLine("Player " + name + " with " + health + " health " + armor + " armor and " + strength + " strength.");
            Console.ReadLine();
        }
    }
}
