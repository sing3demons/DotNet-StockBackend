namespace StockBackend.DTOs
{
     public class ProductRequest
    {
     public string Name { get; set; }
        public string Image { get; set; }
        public int stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

    }
}