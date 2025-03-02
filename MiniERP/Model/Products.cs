using System.ComponentModel.DataAnnotations;

namespace MiniERP.Model
{
    public class Products
    {
        [Key]
        public required int ItemNo { get; set; }
        public required string Description { get; set; }
        public double Price {  get; set; }
        public int? Quantity { get; set; }
    }
}
