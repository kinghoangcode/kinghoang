namespace Order.API.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string OrderCode { get; set; }
        public Guid ProductId { get; set; }
    }
}
