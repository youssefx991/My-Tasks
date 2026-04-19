using Day6_46.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day6_46.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public IActionResult Index()
        {
            return View(EmployeeList.Employees);
        }

        // GET: Employee/Details/5
        public IActionResult Details(int id)
        {
            return View(EmployeeList.Employees.Where(e => e.ID == id).FirstOrDefault());
        }

        // GET: Employee/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            //if (string.IsNullOrEmpty(emp.Name))
            //{
            //    ModelState.AddModelError("Name", "You must enter a name!");
            //}
            //if (emp.Age < 18)
            //{
            //    ModelState.AddModelError("Age", "Age must be +18");
            //}

            if (ModelState.IsValid)
            {
                EmployeeList.Employees.Add(emp);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}

