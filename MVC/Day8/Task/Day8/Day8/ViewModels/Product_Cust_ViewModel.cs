using Day8.Models;
using System.ComponentModel.DataAnnotations;

namespace Day8.ViewModels
{
    public class Product_Cust_ViewModel
    {
        [Key]
        public int CustID { get; set; }
        public string CustName { get; set; }
        public List<Product> Products { get; set; }
    }
}
