namespace MVC_Customer.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
