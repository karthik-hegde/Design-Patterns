using Memento;

var account = new BankAccount();
account.Deposit(100);
account.Deposit(50);
account.ShowBalance();  // Output: 150
account.Withdraw(30);
account.ShowBalance();  // Output: 120
account.Undo();
account.ShowBalance();  // Output: 150
account.Redo();
account.ShowBalance();  // Output: 120
