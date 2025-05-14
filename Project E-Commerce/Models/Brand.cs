using System.ComponentModel.DataAnnotations;

namespace Project_E_Commerce.Models
{
    public class Brand
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        [MaxLength(150)]
        public string? Description { get; set; }
        public required string LogoUrl { get; set; }

        // One-to-Many
        public ICollection<Product>? Products { get; set; }
        //Many to one
        public int ClientId { get; set; }
        public Client? Client { get; set; }


    }
}
