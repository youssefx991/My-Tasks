using Day5.Areas.HR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day5.Areas.HR.Controllers
{
    public class DepartmentController : Controller
    {
        private HRContext Context = new HRContext();
        // GET: DepartmentController
        public ActionResult Index()
        {
            return View(Context.Departments.ToList());
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            return View(Context.Departments.FirstOrDefault(d => d.DeptID == id));
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            try
            {
                Context.Departments.Add(department);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(department);
            }
        }

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Context.Departments.FirstOrDefault(d => d.DeptID == id));
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Department department)
        {
            try
            {
                var existingDepartment = Context.Departments.FirstOrDefault(d => d.DeptID == id);
                if (existingDepartment != null)
                {
                    existingDepartment.Name = department.Name;
                    existingDepartment.Description = department.Description;
                    Context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(department);
            }
        }

        // GET: DepartmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Context.Departments.FirstOrDefault(d => d.DeptID == id));
        }

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Department department)
        {

            var existingDepartment = Context.Departments.FirstOrDefault(d => d.DeptID == department.DeptID);
            if (existingDepartment != null)
            {
                Context.Departments.Remove(existingDepartment);
                Context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

