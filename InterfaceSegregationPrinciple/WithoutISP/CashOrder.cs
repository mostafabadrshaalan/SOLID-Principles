namespace InterfaceSegregationPrinciple.WithoutISP
{
    public class CashOrder : IOrder
    {
        public void ProcessCashInvoice()
        {
            //Code
        }

        public void ProcessCreditInvoice()         //ISP Violation
        {
            throw new NotImplementedException(); //Rewrite code of credit payment implementation
        }

        public void ProcessOnlinePaymentInvoice()  //ISP Violation
        {
            throw new NotImplementedException(); //Rewrite code of online payment implementation
        }
    }
}
