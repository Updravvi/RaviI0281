using System.ComponentModel.DataAnnotations;

namespace MiniERP.Model
{
    public class PurchaseOrder
    {
        [Key]
        public required int OrderNo { get; set; }
        public required int VendorNo { get; set; }
        public int ItemNo { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; } = 0;
    }
}
