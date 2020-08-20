using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class PiggyBank
    {
        // Maintains the current balance of the piggy bank.
        private float currentBalance;
        // Add funds to the value of the current balance.
        public void deposit(float net)
        {
            currentBalance += net;
        }
        // Returns and clears the total current balance.
        public float withdraw()
        {
            float bal = currentBalance;
            currentBalance = 0f;
            return bal;
        }
        // Returns the current balance of the function.
        public float balance()
        {
            return currentBalance;
        }

    }
}
