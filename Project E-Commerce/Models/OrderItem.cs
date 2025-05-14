namespace Project_E_Commerce.Models
{
    public class OrderItem
    {
        
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }

        // Many-to-One
        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
