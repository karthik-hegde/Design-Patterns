
namespace Memento
{
    public class TransactionHistory
    {
        private List<BankAccountState> _states = new List<BankAccountState>();
        private int currentPointer = 0;
        private BankAccount _bankAccount;
        public TransactionHistory(BankAccount account)
        {
            _bankAccount = account;
        }

        public void Backup()
        {
            if (currentPointer < (_states.Count() - 1))
            {
                _states.RemoveRange(currentPointer + 1, _states.Count() - currentPointer - 1);
            }
            _states.Add(_bankAccount.CreateState());
            currentPointer = _states.Count() - 1;
        }

        public void Undo()
        {
            currentPointer--;
            var state = _states[currentPointer];
            _bankAccount.RestoreState(state);
        }

        public void Redo()
        {
            currentPointer++;
            var state = _states[currentPointer];
            _bankAccount.RestoreState(state);
        }
    }
}