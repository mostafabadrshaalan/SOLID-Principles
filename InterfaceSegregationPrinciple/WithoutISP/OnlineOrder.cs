namespace InterfaceSegregationPrinciple.WithoutISP
{
    public class OnlineOrder : IOrder
    {
        public void ProcessCashInvoice()          //ISP Violation
        {
            throw new NotImplementedException(); //Rewrite code of cash payment implementation
        }

        public void ProcessCreditInvoice()        //ISP Violation
        {
            throw new NotImplementedException(); //Rewrite code of credit payment implementation
        }

        public void ProcessOnlinePaymentInvoice()
        {
            //Code
        }
    }
}
