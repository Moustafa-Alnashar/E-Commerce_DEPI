namespace Project_E_Commerce.Models
{
    public class Product_variation
    {
        
        public int Id { get; set; }
        public required string Size { get; set; }
        public required string Color { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int Cart_ItemId { get; set; }
        //many to one 
        public int ProductId { get; set; }
        public required Product Product { get; set; }

    }
}
