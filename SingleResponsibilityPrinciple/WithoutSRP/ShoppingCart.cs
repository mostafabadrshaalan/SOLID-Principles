namespace WithoutSRP
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public List<ProductItem> CartItems { get; set; }

        public bool RemoveFromCart(ProductItem item)
        {
            if (CartItems.Contains(item))
            {
                CartItems.Remove(item);
                return true;
            }

            return false;
        }

        public bool AddToCart(ProductItem item)
        {
            //Check Available Quantity
            var quantityInStock = Stock.productItems.Where(p => p.Id == item.Id).FirstOrDefault().Quantity; //SRPVaiolation

            if (quantityInStock > item.Quantity)
            {
                CartItems.Add(item);
                return true;
            }
            return false;
        }

        public void CreateInvoice() //SRPVaiolation
        {
            //Calc Total Price
            var totalPrice = CartItems.Sum(p => p.Price * p.Quantity);

            //Get Customer Data

            //Save To Database

            //Print Invoice                            //SRPVaiolation

            //Send Invoice To Customer Email           //SRPVaiolation

        }

    }
}
