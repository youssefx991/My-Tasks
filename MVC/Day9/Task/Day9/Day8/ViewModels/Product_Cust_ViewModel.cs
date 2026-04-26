using Day9.Models;
using System.ComponentModel.DataAnnotations;

namespace Day9.ViewModels
{
    public class Product_Cust_ViewModel
    {
        [Key]
        public int CustID { get; set; }
        public string CustName { get; set; }
        public List<Product> Products { get; set; }
    }
}
