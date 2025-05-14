using System.ComponentModel.DataAnnotations;

namespace Project_E_Commerce.Models
{
    public class Review
    {

        public int ReviewId { get; set; }
        public int Rating { get; set; }
        public required string ReviewText { get; set; }
        public DateTime CreatedAt { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        // Many-to-One

        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public Client? Client  { get; set; }
        public Product? Product { get; set; }
    }
}

