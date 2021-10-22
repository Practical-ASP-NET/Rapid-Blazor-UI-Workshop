namespace RapidBlazorUI.Client.Exercises._4_ProductList
{
    public class ProductApi
    {
        public List<Product> Products { get; set; } = new List<Product> { new Product() };

        public class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }

        }
    }
}
