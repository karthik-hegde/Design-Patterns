using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateVendingMachine
{
    public interface IVendingState
    {
        void InsertMoney(decimal amount);
        void SelectProduct(string productCode);

        void DispenseProduct();

        void CancelTransaction();

        void Refill(string productCode, int quantity, decimal? price = (decimal)0.0);
    }
}