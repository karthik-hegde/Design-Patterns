using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    public class ProductSelectedState : IVendingState
    {
        private VendingMachine Machine { get; }


        public ProductSelectedState(VendingMachine machine)
        {
            Machine = machine;
        }

        public void CancelTransaction()
        {
            this.Machine.resetBalance();
            this.Machine.setState(new IdleState(Machine));
        }

        public void DispenseProduct()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney(decimal amount)
        {
            this.Machine.AddBalance(amount);
            Console.WriteLine($"amount added: {amount}, current balance: {this.Machine.CurrentBalance}");
            if (this.Machine.CurrentBalance < this.Machine.Products[this.Machine.selectedProduct].price)
            {
                Console.WriteLine($"Insufficient balance. Add more money to continue. Current Balance: {this.Machine.CurrentBalance}, Product Price: {this.Machine.Products[this.Machine.selectedProduct].price}");
                return;
            }
            else
            {
                Console.WriteLine("Sufficient balance. Confirm transaction");
                this.Machine.setState(new DispensingState(Machine));
            }
        }

        public void Refill(string productCode, int quantity, decimal? price)
        {
            throw new NotImplementedException();
        }

        public void SelectProduct(string productCode)
        {
            throw new NotImplementedException();
        }
    }
}