using Day3_46.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day3_46.Controllers
{
    public class NewEmpController : Controller
    {
        // GET: NewEmpController
        public ActionResult Index()
        {
            return View(EmployeeList.Employees);
        }

        // GET: NewEmpController/Details/5
        public ActionResult Details(int id)
        {
            return View(EmployeeList.Employees.FirstOrDefault(e => e.Id == id));
        }

        // GET: NewEmpController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewEmpController/Create
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewEmpController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(EmployeeList.Employees.FirstOrDefault(e => e.Id == id));
        }

        // POST: NewEmpController/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            var updatedEmp = EmployeeList.Employees.FirstOrDefault(e => e.Id == emp.Id);
            if (updatedEmp != null)
            {
                updatedEmp.Name = emp.Name;
                updatedEmp.Age = emp.Age;
                updatedEmp.Email = emp.Email;
            }

            return RedirectToAction("Index");
        }

        // GET: NewEmpController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewEmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
