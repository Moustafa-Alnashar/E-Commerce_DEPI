using System.ComponentModel.DataAnnotations;

namespace Project_E_Commerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }

        // One-to-Many
        public  ICollection<Product>? Products { get; set; }

        //public override bool Equals(object? obj)
        //{
        //    return obj is Category category &&
        //           Id == category.Id &&
        //           Name == category.Name &&
        //           ImageUrl == category.ImageUrl &&
        //           EqualityComparer<ICollection<Product>>.Default.Equals(Products, category.Products);
        //}

        //public override int GetHashCode()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
