using Day6_46.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day6_46.Controllers
{
    public class StudentController : Controller
    {
        StdDbContext Context = new StdDbContext();

        // GET: StudentController
        public ActionResult Index()
        {
            return View(Context.Students.Include(s => s.Department).ToList());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            ViewBag.Depts = Context.Departments.ToList();
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        public ActionResult Create(Student std)
        {
            ViewBag.Depts = Context.Departments.ToList();

            if (ModelState.IsValid)
            {
                Context.Students.Add(std);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }

        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
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
