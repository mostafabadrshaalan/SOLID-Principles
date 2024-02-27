namespace WithoutSRP
{
    public class Stock
    {
        public int Id { get; set; }
        public static List<ProductItem> productItems { get; set; } = new List<ProductItem>()
        {
            new ProductItem(){Name="Apple",Price=1000m,Quantity=50},
            new ProductItem(){Name="Samsoung",Price=2000m,Quantity=20},
            new ProductItem(){Name="Renp",Price=3000m,Quantity=50}
        };

        public static bool IsAvailable(ProductItem item)
        {
            var quantityInStock = productItems.Where(p => p.Id == item.Id).FirstOrDefault().Quantity;
            return quantityInStock > item.Quantity ? true : false;
        }
    }
}
