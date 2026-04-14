using Day3_46.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day3_46.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult getAll()
        {
            ViewBag.employees = EmployeeList.Employees;
            return View();
        }

        //public IActionResult getById(int num)
        public IActionResult getById(int id)
        {
            ViewBag.selectedEmp = EmployeeList.Employees.FirstOrDefault(e => e.Id == id);
            return View();
        }

        public IActionResult Edit(int id)
        {
            ViewBag.selectedEmp = EmployeeList.Employees.FirstOrDefault(e => e.Id == id);
            return View();
        }

        public IActionResult EditSave(int id, string name, string age, string email)
        {
            var updatedEmp = EmployeeList.Employees.FirstOrDefault(e => e.Id == id);
            if (updatedEmp != null)
            {
                updatedEmp.Name = name;
                updatedEmp.Age = int.Parse(age);
                updatedEmp.Email = email;
            }

            return RedirectToAction("getAll");
        }


        public IActionResult delete(int id)
        {
            var delEmp = EmployeeList.Employees.FirstOrDefault(e => e.Id == id);

            if(delEmp != null)
            {
                EmployeeList.Employees.Remove(delEmp);
            }

            return RedirectToAction("getAll"); 

            //return View("getAll  // viewbag of EmplyeeList will be Null
            //return getAll(); //delete view doesn't exist
        }
    }
}
