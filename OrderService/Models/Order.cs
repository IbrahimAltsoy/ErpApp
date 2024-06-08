namespace OrderService.Models
{
    public class Order
    {
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string OrderNumber { get; set; }
        public string Address { get; set; }
    }
}
