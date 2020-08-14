using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static AUDAndUSDTracker myMoney = new AUDAndUSDTracker();
        static void Main(string[] args)
        {
            myMoney.USD = 500f;
            PrintMoneyStatus();
            myMoney.USD -= 59.99f;
            PrintMoneyStatus();

            Console.ReadKey();
        }

        static void PrintMoneyStatus() 
        {
            Console.WriteLine($"You have S{myMoney.AUD}AUD or S{myMoney.USD}USD");
        }
    }

    class AUDAndUSDTracker
    {
        private float money = 0;
        public float AUD 
        {
            get 
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public float USD
        {
            get
            {
                return money*0.8f;
            }
            set
            {
                money = value*1.25f;
            }
        }
    }
}
