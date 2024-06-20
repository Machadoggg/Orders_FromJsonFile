namespace Orders_FromJsonFile.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public int Index { get; set; }
        public string Guid { get; set; }
        public bool IsActive { get; set; }
        public string Balance { get; set; }
        public string Picture { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime Registered { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<Order> Orders { get; set; }
    }
}
