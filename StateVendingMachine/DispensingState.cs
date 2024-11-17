namespace StateVendingMachine
{
    public class DispensingState : IVendingState
    {
        private VendingMachine Machine;


        public DispensingState(VendingMachine machine)
        {
            Machine = machine;
        }

        public void CancelTransaction()
        {
            this.Machine.resetBalance();
            this.Machine.setState(new IdleState(this.Machine));
        }

        public void DispenseProduct()
        {
            this.Machine.Products[this.Machine.selectedProduct] = (this.Machine.Products[this.Machine.selectedProduct].stock - 1, this.Machine.Products[this.Machine.selectedProduct].price);
            Console.WriteLine("Product dispensed successfully");
            if (this.Machine.CurrentBalance > this.Machine.Products[this.Machine.selectedProduct].price)
            {
                Console.WriteLine($"Refunding additional amount of {this.Machine.CurrentBalance - this.Machine.Products[this.Machine.selectedProduct].price}");
            }
            this.Machine.setState(new IdleState(this.Machine));
        }

        public void InsertMoney(decimal amount)
        {
            Console.WriteLine("Suffient balance already available");
        }

        public void Refill(string productCode, int quantity, decimal? price)
        {
            Console.WriteLine("Cannot refill when a transaction is in progress");
        }

        public void SelectProduct(string productCode)
        {
            Console.WriteLine("Product already selected, restart transaction to select a different product");
        }
    }
}