using Day6.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day6.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DateNotInFuture]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [TotalPricePositive]
        public decimal TotalPrice { get; set; }

        [ForeignKey("Customer")]
        public int CustID { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}

/*
    - ID
    - Date
    - TotalPrice
    [ForeignKey("Customer")]
    - CustID
    - Customer ? Customer
*/