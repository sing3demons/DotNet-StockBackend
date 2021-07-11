namespace StockBackend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }

}
