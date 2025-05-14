namespace Project_E_Commerce.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public required string TransactionId { get; set; }

        public required string PaymentMethod { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // One-to-One relationship with Order
        public int OrderId { get; set; }

        public Order? Order { get; set; }
    }
}
