namespace MVC_Customer.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
