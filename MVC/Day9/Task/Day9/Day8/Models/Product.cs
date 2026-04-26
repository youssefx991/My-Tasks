using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day9.Models
{
    [Table("Product")]
    public class Product
    {
        /*
         * Product should have the following properties:
        - ID
        - Name
        - Image
        - Price
        - Description
          [ForeignKey("Customer")]
        - CustID
        - Customer Customer
         */
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Image { get; set; }

        [Range(1, double.MaxValue)]
        public double? Price { get; set; }

        [Required]
        public string? Description { get; set; }

        [ForeignKey("Customer")]
        public int? CustID { get; set; }

        public virtual Customer? Customer { get; set; }

    }
}
