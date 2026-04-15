using Day3_46.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day3_46.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult getAll()
        {
            //ViewBag.employees = EmployeeList.Employees;
            return View(EmployeeList.Employees);
        }

        //public IActionResult getById(int num)
        public IActionResult getById(int id)
        {
           // ViewBag.selectedEmp = EmployeeList.Employees.FirstOrDefault(e => e.Id == id);
            ViewBag.ProjName = "Project_1";
            ViewBag.Hours = 30;

            ViewData["msg"] = "test message";

            return View(EmployeeList.Employees.FirstOrDefault(e => e.Id == id));
        }


        //[HttpGet]
        public IActionResult Edit(int id)
        {
            //ViewBag.selectedEmp = EmployeeList.Employees.FirstOrDefault(e => e.Id == id);
            return View(EmployeeList.Employees.FirstOrDefault(e => e.Id == id));
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, string age, string email)
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

        //public IActionResult EditSave(IFormCollection collection)
        //{
        //    int id = int.Parse(collection["id"]);

        //    var updatedEmp = EmployeeList.Employees.FirstOrDefault(e => e.Id == id);
        //    if (updatedEmp != null)
        //    {
        //        updatedEmp.Name = collection["name"];
        //        updatedEmp.Age = int.Parse(collection["age"]);
        //        updatedEmp.Email = collection["email"];
        //    }

        //    return RedirectToAction("getAll");
        //}

        //public IActionResult EditSave([Bind(include: "Id, Name")] Employee emp)
        //{
        //    var updatedEmp = EmployeeList.Employees.FirstOrDefault(e => e.Id == emp.Id);
        //    if (updatedEmp != null)
        //    {
        //        updatedEmp.Name = emp.Name;
        //        updatedEmp.Age = emp.Age;
        //        updatedEmp.Email = emp.Email;
        //    }

        //    return RedirectToAction("getAll");
        //}

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
