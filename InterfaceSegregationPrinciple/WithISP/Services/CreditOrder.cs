using InterfaceSegregationPrinciple.WithISP.Interfaces;

namespace InterfaceSegregationPrinciple.WithISP.Services
{
    public class CreditOrder : ICreditOrder
    {
        public void ProcessCreditInvoice()
        {
            throw new NotImplementedException();
        }
    }
}
