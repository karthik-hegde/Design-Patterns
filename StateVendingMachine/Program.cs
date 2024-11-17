using StateVendingMachine;

VendingMachine vendingMachine = new VendingMachine();
vendingMachine.Refill("Pepsi", 5, 10);
vendingMachine.Refill("Coke", 5, 4);
vendingMachine.SelectProduct("Coke");
vendingMachine.InsertMoney(5);
vendingMachine.DispenseProduct();