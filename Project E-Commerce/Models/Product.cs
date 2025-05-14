using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Project_E_Commerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public string? ImageUrl { get; set; }
        public required string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        //many to one 
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        //one to many
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
        public ICollection<Product_variation>? ProductVariations { get; set; }
        public ICollection<Wishlist>? Wishlists { get; set; }

    }
}
