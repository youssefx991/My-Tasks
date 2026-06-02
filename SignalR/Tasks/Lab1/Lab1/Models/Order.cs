using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? ItemName { get; set; }

        public int? ItemCount { get; set; }
    }
}
