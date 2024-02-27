using WithoutSRP;

namespace WithSRP
{
    public class Invoice
    {
        public void CreateInvoice(ShoppingCart cart, int customerId)
        {
            //Calc Total Price
            var totalPrice = cart.CartItems.Sum(p => p.Price * p.Quantity);

            //Get Customer Data

            //Save To Database

            //Print Invoice
            PrintInvoice("");

            //Send Invoice To Customer Email 
            EmailSettings.Send(new Email());



        }

        public void PrintInvoice(string text) { }

    }
}
