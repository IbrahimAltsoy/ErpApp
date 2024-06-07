namespace ProductService.Api.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Stock { get; set; }
    }
}
