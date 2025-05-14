namespace Project_E_Commerce.Models
{
    public class Employee

    {
        // can delet , mange & develope
        public int  Id { get; set; }
        public required string Name { get; set; }
        public int Phone { get; set; }
        public string? Adress { get; set; }

        public DateTime HireDate { get; set; }

        public string? Role { get; set; }
        public string? Type { get; set; }

        // many to one 
        //public User user { get; set; }
       // public int UserId { get; set; }


    }
}

