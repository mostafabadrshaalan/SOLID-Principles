namespace InterfaceSegregationPrinciple.WithoutISP
{
    public interface IOrder
    {
        void ProcessCashInvoice();
        void ProcessCreditInvoice();
        void ProcessOnlinePaymentInvoice();
    }
}
