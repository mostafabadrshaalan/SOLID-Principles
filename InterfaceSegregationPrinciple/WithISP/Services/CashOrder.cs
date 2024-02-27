using InterfaceSegregationPrinciple.WithISP.Interfaces;

namespace InterfaceSegregationPrinciple.WithISP.Services
{
    public class CashOrder : ICashOrder
    {
        public void ProcessCashInvoice()
        {
            throw new NotImplementedException();
        }
    }
}
