using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    public class VendingMachine
    {

        public Dictionary<string, (int stock, decimal price)> Products { get; private set; } = new();
        public decimal CurrentBalance { get; private set; } = 0;
        public string selectedProduct { get; set; } = "";
        private IVendingState currentState;

        public VendingMachine()
        {
            currentState = new IdleState(this);
        }
        public void InsertMoney(decimal amount)
        {
            currentState.InsertMoney(amount);
        }
        public void SelectProduct(string productCode)
        {
            currentState.SelectProduct(productCode);
        }

        public void DispenseProduct()
        {
            currentState.DispenseProduct();
        }

        public void CancelTransaction()
        {
            currentState.CancelTransaction();
        }

        public void Refill(string productCode, int quantity, decimal price = (decimal)1.0)
        {
            currentState.Refill(productCode, quantity, price);
        }

        public void AddBalance(decimal amount)
        {
            this.CurrentBalance += amount;
        }

        public void resetBalance()
        {
            this.CurrentBalance = 0;
        }
        public void setState(IVendingState state)
        {
            this.currentState = state;
        }
    }
}