using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    public class IdleState : IVendingState
    {
        private VendingMachine Machine;
        public IdleState(VendingMachine machine)
        {
            Machine = machine;
        }
        public void CancelTransaction()
        {
            Console.WriteLine("No transaction in progress");
        }

        public void DispenseProduct()
        {
            Console.WriteLine("Select Product First");
        }

        public void InsertMoney(decimal amount)
        {
            Console.WriteLine("Select Product First");
        }

        public void Refill(string productCode, int quantity, decimal? price)
        {
            this.Machine.Products.Add(productCode, (quantity, price ?? (decimal)0.00));
            Console.WriteLine("Product added successfully");
        }

        public void SelectProduct(string productCode)
        {
            if (this.Machine.Products.ContainsKey(productCode) && this.Machine.Products[productCode].stock > 0)
            {
                this.Machine.selectedProduct = productCode;
                this.Machine.setState(new ProductSelectedState(Machine));
            }
            else
            {
                Console.WriteLine("Select product is unavailable");
            }
        }
    }
}