using System;
/// <summary>
/// An Unimaginative Guess the number engine
/// Deliberatly dumb.
/// With some deliberate logic
/// </summary>
namespace GuessTheNumber
{
    class Program
    {
        /// <summary>
        /// Main is your programs entrypoint, for most purposes you should
        /// regard it as being the first piece of code in your program that will be executed.
        /// (this is almost 99% true, and is good enough for now.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random nGenerator = new Random();
            //Some error trapping
            if (args.Length < 2)
            {
                Console.WriteLine("GuessTheNumber requires 2 parameters the first is the number of guesses, the second is the max number I pick from.");
                return;
            }

            int numberOfTries = 0;
            int ceiling = 0;
            //Check if args are in correct format
            if (!(int.TryParse(args[1], out ceiling) && int.TryParse(args[0], out numberOfTries)))
            {
                Console.WriteLine("GuessTheNumber requires 2 parameters both in the format of a whole number. Example: 50");
                return;
            }


            bool keepGoing = true;

            while (keepGoing)
            {
                //generate a new random number
                int myNumber = nGenerator.Next(ceiling);
                string playerGuess = "";
                int playerGuessNum = -1;
                Console.WriteLine($"I am thinking of a whole number between 0 and {ceiling}");
                Console.WriteLine($"Can you try and guess it in less than {numberOfTries} tries ?");
                int guessCount = 0;
                //main game loop
                for (int i = numberOfTries; i > 0 && playerGuessNum != myNumber; i--)
                {
                    Console.WriteLine("You have " + i.ToString() + " tries left.");
                    Console.WriteLine("Take a guess.");
                    //make sure the guess format is correct
                    while (true)
                    {
                        playerGuess = Console.ReadLine();
                        if (int.TryParse(playerGuess, out playerGuessNum))
                        {
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("No! Type a number");
                        }
                    }
                    guessCount++;
                    if (playerGuessNum == myNumber)
                    {
                        Console.WriteLine($"Well Done. You took {guessCount} attempts.");
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("Too bad you didn't guess it, I'm just too smart.");
                    }
                    else
                    {
                        if (playerGuessNum > myNumber)
                        {
                            Console.WriteLine("Too High, Try again.");
                        }
                        else
                        {
                            Console.WriteLine("Too Low, Try again.");
                        }
                    }
                }
                Console.WriteLine("Go again? y/n");
                while (true) {
                    string response = Console.ReadLine();
                    if (response.ToLower().StartsWith("y"))
                    {
                        Console.WriteLine("Ok, again!");
                        break;
                    }
                    else if (response.ToLower().StartsWith("n"))
                    {
                        keepGoing = false;
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("What you type must start with the letter \"y\" or \"n\"");
                    }
                }
            }
            
        }
    }
}
