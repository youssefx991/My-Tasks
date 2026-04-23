using _7_NetCORE.Models;
using _7_NetCORE.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _7_NetCORE.Controllers
{
    public class testDataController : Controller
    {
        // MainDbContext db = new MainDbContext();

        public MainDbContext Context { get; }
        public testDataController(MainDbContext context)
        {
            Context = context;
        }

        public IActionResult ShowStdCrsDetails(int id)
        {
            // get required data from database & other 

            Student St = Context.Students.Find(id);
            Department Dpt = Context.Departments.Find(St.DeptID);

            List<string> CrsNames = new List<string>() { "C#", "ASP.NET", "SQL Server" };
            int num = 30;

            //Create a ViewModel object & assign data to it

            StdDeptCrsLstViewModel StdViewModel = new StdDeptCrsLstViewModel()
            {
                StdID = St.StudentID,
                StdName = St.StdName,
                CourseList = CrsNames,
                CrsHrs = num,
                Dept = Dpt
            };

            return View(StdViewModel);
        }
    }
}
