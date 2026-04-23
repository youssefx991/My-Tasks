using _7_NetCORE.Models;
using System.ComponentModel.DataAnnotations;

namespace _7_NetCORE.ViewModels
{
    public class StdDeptCrsViewModel
    {
        [Key]
        public int StdID { get; set; }
        public string StdName { get; set; }
        public List<string> CourseList { get; set; }
        public int CrsHrs { get; set; }
        public Department Dept { get; set; }

    }
}
