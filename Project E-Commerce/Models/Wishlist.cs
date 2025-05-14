namespace Project_E_Commerce.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        // Many-to-One

        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
