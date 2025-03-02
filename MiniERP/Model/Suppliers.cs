using System.ComponentModel.DataAnnotations;

namespace MiniERP.Model
{
    public class Suppliers
    {
        [Key]
        public required int VendorNo { get; set; }
        public required string Name { get; set; }

    }
}
