using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    class RomanNumeral
    {
        private int value;
        public RomanNumeral(int value)
        {
            this.value = value;
        }
        // Declare a conversion from an int to a RomanNumeral. Note the
        // the use of the operator keyword. This is a conversion
        // operator named RomanNumeral:
        static public implicit operator RomanNumeral(int value)
        {
            // Note that because RomanNumeral is declared as a struct,
            // calling new on the struct merely calls the constructor
            // rather than allocating an object on the heap:
            return new RomanNumeral(value);
        }
        // Declare an explicit conversion from a RomanNumeral to an int:
        static public explicit operator int(RomanNumeral roman)
        {
            return roman.value;
        }
        // Declare an implicit conversion from a RomanNumeral to
        // a string:
        static public implicit operator string(RomanNumeral roman)
        {
            string output = "";
            int workingValue = (int)roman;
            while (workingValue > 0) 
            {
                if (workingValue >= 1000)
                {
                    output += "M";
                    workingValue -= 1000;
                }
                else if (workingValue < 1000 && workingValue >= 900)
                {
                    output += "CM";
                    workingValue -= 900;
                }
                else if (workingValue >= 500)
                {
                    output += "D";
                    workingValue -= 500;
                }
                else if (workingValue < 500 && workingValue >= 400)
                {
                    output += "CD";
                    workingValue -= 400;
                }
                else if (workingValue >= 100)
                {
                    output += "C";
                    workingValue -= 100;
                }
                else if (workingValue < 100 && workingValue >= 90)
                {
                    output += "XC";
                    workingValue -= 90;
                }
                else if (workingValue >= 50)
                {
                    output += "L";
                    workingValue -= 50;
                }
                else if (workingValue < 50 && workingValue >= 40)
                {
                    output += "XL";
                    workingValue -= 40;
                }
                else if (workingValue >= 10)
                {
                    output += "X";
                    workingValue -= 10;
                }
                else if (workingValue == 9)
                {
                    output += "IX";
                    workingValue -= 9;
                }
                else if (workingValue >= 5)
                {
                    output += "V";
                    workingValue -= 5;
                }
                else if (workingValue == 4)
                {
                    output += "IV";
                    workingValue -= 4;
                }
                else if(workingValue < 4)
                {
                    output += "I";
                    workingValue -= 1;
                }
            }
            return output;
        }

        static public implicit operator RomanNumeral(BinaryNumeral binary)
        {
            return new RomanNumeral((int)binary);
        }

    }
}
