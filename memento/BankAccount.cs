using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Memento.Interface;

namespace Memento
{
    public class BankAccount : IBankAccount, IHistory
    {
        private double _balance { get; set; }
        private TransactionHistory _transactionHistory;

        public BankAccount()
        {
            _balance = 0;
            _transactionHistory = new TransactionHistory(this);
        }
        public BankAccount(double balance)
        {
            _balance = balance;

            _transactionHistory = new TransactionHistory(this);
        }
        public void Deposit(double amount)
        {
            _balance += amount;
            _transactionHistory.Backup();
        }

        public double ShowBalance()
        {
            Console.WriteLine($"Current Balance: {_balance}");
            return _balance;
        }

        public void Undo()
        {
            _transactionHistory.Undo();
        }

        public void Withdraw(double amount)
        {
            if (amount > _balance)
            {
                throw new InvalidOperationException("Balance too low");
            }
            _balance -= amount;
            _transactionHistory.Backup();
        }

        public void Redo()
        {
            _transactionHistory.Redo();
        }

        public BankAccountState CreateState()
        {
            return new BankAccountState(this._balance);
        }

        public void RestoreState(BankAccountState state)
        {
            this._balance = state.GetBalance();
        }
    }
}