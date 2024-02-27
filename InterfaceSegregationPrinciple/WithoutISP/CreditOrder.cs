namespace InterfaceSegregationPrinciple.WithoutISP
{
    public class CreditOrder : IOrder
    {
        public void ProcessCashInvoice()          //ISP Violation
        {
            throw new NotImplementedException();  //Rewrite code of cash payment implementation
        }

        public void ProcessCreditInvoice()
        {
            //Code
        }

        public void ProcessOnlinePaymentInvoice() //ISP Violation
        {
            throw new NotImplementedException(); //Rewrite code of online payment implementation
        }
    }
}
