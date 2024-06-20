namespace Orders_FromJsonFile.Models
{
    public class Order
    {
        public string Id { get; set; }
        public List<OrderDetail> Details { get; set; }
    }
}
