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

            if (Stock.IsAvailable(item))
            {
                CartItems.Add(item);
                return true;
            }
            return false;
        }



    }
}
