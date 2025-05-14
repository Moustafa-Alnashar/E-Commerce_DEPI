namespace Project_E_Commerce.Models
{
    public class MyCart
    {
        public int Id { get; set; }
        public User  User { get; set; }
        public int UserId { get; set; }
        public ICollection<Cart_Item> Items { get; set; }

    }
}
