using _7_NetCORE.Models;
using _7_NetCORE.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _7_NetCORE.Controllers
{
    public class testDataController : Controller
    {
        public StdContext Context { get; }
        public testDataController(StdContext context)
        {
            Context = context;
        }

        public IActionResult testView(int id)
        {
            //get required data from DB
            Student St = Context.Students.Find(id);
            Department Dpt = Context.Departments.Find(St.DeptID);

            List<string> CrsLst = new List<string>() { "C#", "DB", "MVC" };
            int num = 30;

            //Create ViewModel Objet and set data into it
            StdDeptCrsViewModel StdViewModel = new StdDeptCrsViewModel()
            {
                StdID = St.StudentID,
                StdName = St.StdName,
                CourseList = CrsLst,
                CrsHrs = num,
                Dept = Dpt
            };

            return View(StdViewModel);
        }
    }
}
