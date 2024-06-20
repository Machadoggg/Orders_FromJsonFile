namespace Orders_FromJsonFile.Models
{
    public class OrderDetail
    {
        public string DatilId { get; set; } = default!;
        public int PluId { get; set; }
        public int Quantity { get; set; }
    }
}
