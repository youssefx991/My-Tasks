using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day5_46.Models
{
    [Table("City")]
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        
        [ForeignKey("Cntry")]
        public int cID { get; set; }
        
        public virtual Country Cntry { get; set; }
    }
}
