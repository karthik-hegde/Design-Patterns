using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memento
{
    public class BankAccountState
    {
        private double _balance;

        public BankAccountState(double balance)
        {
            this._balance = balance;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}