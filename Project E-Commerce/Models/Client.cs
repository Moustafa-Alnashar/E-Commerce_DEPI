namespace Project_E_Commerce.Models
{
    public class Client 
    {
        // can buy & add to cart
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public DateTime HierDate { get; set; }
        public string Type { get; set; } // Howner-Brand   Normal ueser

        //  many to one 
       // public User user { get; set; }
      //  public int UserId { get; set; }
            
    }
}
