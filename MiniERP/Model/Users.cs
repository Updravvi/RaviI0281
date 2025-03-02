using System.ComponentModel.DataAnnotations;

namespace MiniERP.Model
{
    public class Users
    {
        [Key]
        public required int UserID { get; set; }
        public required string Name { get; set; }
        public required string Role { get; set; }
    }
}
