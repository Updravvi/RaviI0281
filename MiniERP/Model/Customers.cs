using System.ComponentModel.DataAnnotations;

namespace MiniERP.Model
{
    public class Customers
    {
        [Key]
        public required int CustomerNo { get; set; }
        public required string Name { get; set; }
        public string? Address { get; set; }
        public int? PhoneNo { get; set; }
    }
}
