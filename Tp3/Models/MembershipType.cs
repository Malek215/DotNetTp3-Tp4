using Tp3.Models;

namespace Tp3.Models
{
    public class MemberShipType
    {
        public int Id { get; set; }
        public float SingUpFee { get; set; }
        public int DurationInMonth { get; set; }
        public float DiscountRate { get; set; }
        public string? Name { get; set; }
        public List<Customer>? Customers { get; set; }
    }
}