using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    class BinaryNumeral
    {
        private int value;
        public BinaryNumeral(int value)
        {
            
            this.value = value;
        }
        // Declare a conversion from an int to a BinaryNumeral. Note the
        // the use of the operator keyword. This is a conversion
        // operator named RomanNumeral:
        static public implicit operator BinaryNumeral(int value)
        {
            // Note that because BinaryNumeral is declared as a struct,
            // calling new on the struct merely calls the constructor
            // rather than allocating an object on the heap:
            return new BinaryNumeral(value);
        }
        // Declare an explicit conversion from a BinaryNumeral to an int:
        static public explicit operator int(BinaryNumeral binary)
        {
            return binary.value;
        }
        // Declare an implicit conversion from a BinaryNumeral to
        // a string:
        static public implicit operator string(BinaryNumeral binary)
        {
            string output = "";
            int workingValue = (int)binary;
            if (workingValue > 0)
            {
                int zeros = 0;
                int value = 1;
                while (value <= workingValue)
                {
                    value *= 2;
                    zeros++;
                }
                value /= 2;
                zeros--;
                workingValue -= value;
                output = "1";
                for (int i = 0; i < zeros; i++)
                {
                    output += "0";
                }
                while (workingValue > 0)
                {
                    zeros = 0;
                    value = 1;
                    while (value <= workingValue)
                    {
                        value *= 2;
                        zeros++;
                    }
                    value /= 2;
                    zeros--;
                    workingValue -= value;

                    StringBuilder sb = new StringBuilder(output);
                    sb[output.Length-zeros-1] = '1';
                    output = sb.ToString();
                }

                return output;
            }
            else 
            {
                return "0";
            }
            
            
        }


    }
}
