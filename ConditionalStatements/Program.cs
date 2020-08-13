using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main() {
            bool playerAlive = true;
            int invunerabilityTimer = 1;
            invunerabilityTimer--;
            if (invunerabilityTimer > 0)
            {
                if (playerAlive) 
                {
                    invunerabilityTimer--;
                }
                Console.WriteLine("Congrats you can't escape");
            }
            else if (invunerabilityTimer == 0)
            {
                Console.WriteLine("Congrats you can escape");
            }
            else if (invunerabilityTimer < 0) 
            {
                invunerabilityTimer = 0;
            }
            if (playerAlive)
            {
                Console.WriteLine("You're still alive");
            }
            else 
            {
                Console.WriteLine("You're dead, congrats you escaped 2020");
            }
            Console.ReadLine();
            
            /*
            int score = 0; 
            int combo = 1; 
            int pointValue = 100; 
            bool gameStarted = false; 
            if (score == 0) 
            { gameStarted = true; 
                if (gameStarted) 
                { score = combo * pointValue; 
                    combo++; 
                    Console.WriteLine("You got a combo! Your new score is: " + score); 
                    Console.ReadKey(); 
                } 
            }



            
            int playerHealth = 100; 
            int monsterDamage = 70; 
            playerHealth -= monsterDamage;
            if (playerHealth < 0) 
            {
                playerHealth = 0;
            }
            Console.WriteLine("A monster attacked you and did " + monsterDamage + " damage. You have " + playerHealth + " health left.");
            if (playerHealth == 0)
            {
                Console.WriteLine("You died. Game over.");
            }
            else if (monsterDamage > 100) 
            {
                Console.WriteLine("The monster is terrifingly strong.");
            }
            else if (playerHealth > 0)
            {
                Console.WriteLine("The monster prepares to attack you again!");
            }
            Console.ReadKey(); 
            */
        }
    }
}
