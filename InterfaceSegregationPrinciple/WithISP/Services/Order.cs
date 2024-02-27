using InterfaceSegregationPrinciple.WithISP.Interfaces;

namespace InterfaceSegregationPrinciple.WithISP.Services
{
    public class Order : IOrder
    {
        public void ProcessCashInvoice()
        {
            throw new NotImplementedException();
        }

        public void ProcessCreditInvoice()
        {
            throw new NotImplementedException();
        }
    }
}
