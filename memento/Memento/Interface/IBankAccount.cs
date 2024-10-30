using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memento.Interface
{
    public interface IBankAccount
    {
        void Deposit(double amount);
        double ShowBalance();
        void Withdraw(double amount);

    }
}