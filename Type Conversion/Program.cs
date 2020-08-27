using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeral roman;
            roman = 10;
            BinaryNumeral binary;
            // Perform a conversion from a RomanNumeral to a
            // BinaryNumeral:
            binary = (BinaryNumeral)(int)roman;
            // Performs a conversion from a BinaryNumeral to a RomanNumeral.
            // No cast is required:
            roman = binary;
            Console.WriteLine((int)binary);
            Console.WriteLine(binary);
            Console.ReadKey();
        }
    }
}
