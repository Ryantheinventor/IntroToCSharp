using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.score = 100;
            game.Start();
            Console.ReadKey();
            
        }
    }
}
