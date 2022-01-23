using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts.Encapsulation
{
    internal class SBIAccount : Account
    {
        private int balance;
        public int getBalance()
        {
            return balance;
        }

        public void setBalance(int balance)
        {
            this.balance = balance;
        }
    }
}
