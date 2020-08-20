using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //no error checking will be performed in this file

            //9
            int[,] kilos = new int[3, 7];

            //initial input
            for (int dragon = 0; dragon < 3; dragon++) 
            {
                for (int day = 0; day < 7; day++) 
                {
                    Console.WriteLine($"How many kilos did dragon {dragon+1} eat on day {day+1}");
                    kilos[dragon, day] = int.Parse(Console.ReadLine());
                }
            }
            //report average amount of food eaten per day by all the dragons together
            int totalKilos = 0;
            for (int dragon = 0; dragon < 3; dragon++)
            {
                for (int day = 0; day < 7; day++)
                {
                    totalKilos += kilos[dragon, day];
                }
            }
            Console.WriteLine($"The all ate an average of {totalKilos/21} kilo(s) per day");

            //report average amount of food eaten per day by any one dragon
            
            for (int dragon = 0; dragon < 3; dragon++)
            {
                int totalDragonKilos = 0;
                for (int day = 0; day < 7; day++)
                {
                    totalDragonKilos += kilos[dragon, day];
                }
                Console.WriteLine($"Dragon {dragon+1} ate an average of {totalDragonKilos / 7} kilo(s) per day");
            }
            

            //report the greatest amount of food eaten during one day and which dragon that was
            int maxK = 0;
            int maxDay = 0;
            int maxDragon = 0;
            for (int dragon = 0; dragon < 3; dragon++)
            {
                for (int day = 0; day < 7; day++)
                {
                    if (kilos[dragon, day] > maxK)
                    {
                        maxK = kilos[dragon, day];
                        maxDay = day;
                        maxDragon = dragon;
                    }
                }
            }
            Console.WriteLine($"Dragon {maxDragon + 1} ate {kilos[maxDragon, maxDay]} kilo(s) on day {maxDay + 1}.");

            //report the least amount of food eaten during one day and which dragon that was
            int minK = maxK;
            int minDay = 0;
            int minDragon = 0;
            for (int dragon = 0; dragon < 3; dragon++)
            {
                for (int day = 0; day < 7; day++)
                {
                    if (kilos[dragon, day] < minK)
                    {
                        minK = kilos[dragon, day];
                        minDay = day;
                        minDragon = dragon;
                    }
                }
            }
            Console.WriteLine($"Dragon {minDragon + 1} ate {kilos[minDragon, minDay]} kilo(s) on day {minDay + 1}.");


            /*
            //8
            int[] healths = { 100, 100, 100, 100, 100};
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Pick a character to be attacked (0-4)");
                int character = int.Parse(Console.ReadLine());
                int damage = new Random().Next(10, 60);
                healths[character] -= damage;
                Console.WriteLine($"The monster attacked character {character} and did {damage} damage. Character {character} now has {healths[character]} health.");
            }
            //I know a loop would be good here
            Console.WriteLine($"Character 0 now has {healths[0]} health.");
            Console.WriteLine($"Character 1 now has {healths[1]} health.");
            Console.WriteLine($"Character 2 now has {healths[2]} health.");
            Console.WriteLine($"Character 3 now has {healths[3]} health.");
            Console.WriteLine($"Character 4 now has {healths[4]} health.");
            */

            /*
            //7
            //this should work but I really don't want to pupulate this
            int[,] days = new int[29, 5];

            for (int x = 0; x < 29; x++)
            {
                int sum = 0;
                for (int y = 0; y < 5; y++)
                {
                    sum += days[x, y];
                }
                Console.WriteLine(sum);
            }
            for (int y = 0; y < 5; y++)
            {
                int sum = 0;
                for (int x = 0; x < 29; x++)
                {
                    sum += days[x, y];
                }
                Console.WriteLine(sum);
            }
            */

            /*
            //6
            int[,] grid = new int[3, 3];
            int value = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    value++;
                    grid[x, y] = value;
                }
            }
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(grid[x, y]);
                }
                Console.WriteLine();
            }
            */

            /*
            //5
            int[] data = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter a number to be put in position {i}.");
                data[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{data.Max()} is the largest number");
            Console.WriteLine($"{data.Min()} is the smallest number");
            */


            /*
            //4
            int[] data = new int[4];
            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine($"Enter a number to be put in position {i}.");
                data[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(data[i]);
            }
            */

            /*
            //3
            int[] data = new int[10];
            for (int i = 0; i < 10; i++) 
            {
                data[i] = 10 - i;
            }
            foreach (int i in data) 
            {
                Console.WriteLine(i);
            }
            */

            Console.ReadLine();

        }
    }
}
