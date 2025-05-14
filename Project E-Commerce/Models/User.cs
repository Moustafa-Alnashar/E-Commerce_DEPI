using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Project_E_Commerce.Models
{
    public class User : IdentityUser
    {
        public required string Name { get; set; }
        public string? Phone { get; set; }
        public  string? Address { get; set; }
        public required string Type { get; set; }
        public DateTime CreatedAt { get; set; }
      //  public required MyCart MyCart { get; set; }

        // One-to-Many
       // public required ICollection<Order> Orders { get; set; }
       // public  ICollection<Review>? Reviews { get; set; }
       // public ICollection<Wishlist>? Wishlists { get; set; }
       // public ICollection<Employee>? Employees { get; set; }
       // public ICollection<Client>? Clients { get; set; }
       // public required Brand Brand { get; set; }

    }
}
