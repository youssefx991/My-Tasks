using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day8.Models
{
    [Table("Customer")]
    public class Customer
    {
        /*
        Customer should have the following properties:
        - ID
        - Name
        - Gender
        - Email
        - PhoneNum
        - IEnumrable<Product>? Products
        */
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender? Gender { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Phone]
        public string? PhoneNum { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }

}