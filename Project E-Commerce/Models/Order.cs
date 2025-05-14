using Microsoft.EntityFrameworkCore;

namespace Project_E_Commerce.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Precision(18, 2)]
        public decimal TotalPrice { get; set; }

        public string? Status { get; set; }

        public required string PaymentStatus { get; set; }

        public required string ShippingStatus { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Many-to-One relationship with Client
        public int ClientId { get; set; }

        public Client? Client { get; set; }

        // One-to-Many relationship with OrderItems
        public ICollection<OrderItem>? OrderItems { get; set; }

        // One-to-One relationship with Payment
        public Payment? Payment { get; set; }
    }
}
