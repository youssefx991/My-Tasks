using Day5.Areas.HR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Day5.Areas.HR.Controllers
{
    public class EmployeeController : Controller
    {
        private HRContext Context = new HRContext();
        // GET: EmployeeController
        public ActionResult Index()
        {
            ViewBag.Departments = new SelectList(Context?.Departments?.ToList(), "DeptID", "Name", -1);
            return View(Context?.Employees?.Include(e => e.Dept).ToList());
        }
        [HttpPost]
        public ActionResult Index(int DeptID)
        {
            Console.WriteLine($"DeptID = {DeptID}");
            ViewBag.Departments = new SelectList(Context?.Departments?.ToList(), "DeptID", "Name", DeptID);
            if (DeptID != -1)
            {
                return View(Context?.Employees?.Include(e => e.Dept).Where(e => e.DeptID == DeptID).ToList());
            }
            else
            {
                return View(Context?.Employees?.Include(e => e.Dept).ToList());
            }
        }


        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View(Context.Employees.Include(e => e.Dept).FirstOrDefault(e => e.EmpID == id));
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            ViewBag.Departments = Context.Departments.ToList();
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            if (emp != null)
            {
                Context.Employees.Add(emp);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(emp);
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Departments = Context.Departments.ToList();
            return View(Context.Employees.Include(e => e.Dept).FirstOrDefault(e => e.EmpID == id));
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            Employee EditedEmployee = Context.Employees.FirstOrDefault(e => e.EmpID == emp.EmpID);
            if (EditedEmployee != null)
            {
                EditedEmployee.Name = emp.Name;
                EditedEmployee.Password = emp.Password;
                EditedEmployee.Salary = emp.Salary;
                EditedEmployee.JoinDate = emp.JoinDate;
                EditedEmployee.Email = emp.Email;
                EditedEmployee.PhoneNum = emp.PhoneNum;
                EditedEmployee.DeptID = emp.DeptID;
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(emp);
            }

        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Context.Employees.Include(e => e.Dept).FirstOrDefault(e => e.EmpID == id));
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Employee emp)
        {

            Employee DeletedEmployee = Context.Employees.FirstOrDefault(e => e.EmpID == emp.EmpID);
            if (DeletedEmployee != null)
            {
                Context.Employees.Remove(DeletedEmployee);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(emp);
            }
        }
    }
}
