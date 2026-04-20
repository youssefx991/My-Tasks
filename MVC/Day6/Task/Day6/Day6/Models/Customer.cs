using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6.Models
{
    [Table("Customer")]

    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DisplayName("Customer Name")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]
        public string Name { get; set; }

        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required]
        [EmailAddress]
        [EmailUnique]
        [DisplayName("Customer Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^01[0125]\d{8}$", ErrorMessage = "Invalid phone number.")]
        [PhoneNumberUnique]
        public string? PhoneNum { get; set; }

        public virtual IEnumerable<Order>? Orders { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}

/*
    - ID
    - Name
    - Gender
    - Email
    - PhoneNum
    - IEnumrable<Order>? Orders --> Nullable

 */