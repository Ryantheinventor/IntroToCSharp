using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Functions
{
    class Game
    {
        public int score = 0;
        public void Start() 
        {
            PrintScore(50);
            PrintScore(2346);
            PrintScore(1);
        }

        public int AddToScore(int add) 
        {
            score += add;
            return score;
        }

        public void PrintScore(int add) 
        {
            Console.WriteLine($"You scored {AddToScore(add)}!");
        }

        /*
        int numberOne = 10;
        int numberTwo = 200;
        public void Start()
        {
            int biggestNumber = ReturnBiggestNumber(numberOne, numberTwo);
            Console.WriteLine($"Of {numberOne} and {numberTwo} the biggest number is {biggestNumber}");
           
            Console.ReadKey();
        }
        int ReturnBiggestNumber(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        */

        /*
        int playerHealth = 100;
        int monsterDamage = 30;
        public void Start() 
        {
            Console.WriteLine("My game has begun!");
            Console.ReadKey();
            MonsterEncounter();
        }
        private void MonsterEncounter() 
        {
            Console.WriteLine("A vicious monster appears!");
            Console.ReadKey();
            MonsterAttacks(monsterDamage * 2);
            MonsterAttacks(monsterDamage);
            MonsterAttacks(monsterDamage * 3);

        }
        private void MonsterAttacks(int damage) 
        {
            
            playerHealth -= damage;
            Console.WriteLine($"The monster hits you for {damage} points of damage. You have {playerHealth} health left.");
            Console.ReadKey();
        }
        */
    }
}
