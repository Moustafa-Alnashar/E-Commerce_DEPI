namespace Project_E_Commerce.Models
{
    public class Cart_Item
    {
        public int Id { get; set; }
        public int Quantity  { get; set; }
        public int Product_variationId { get; set; }
        //one to many 
        public int MyCartId { get; set; }
        public required MyCart MyCart { get; set; }
            
    }
}
