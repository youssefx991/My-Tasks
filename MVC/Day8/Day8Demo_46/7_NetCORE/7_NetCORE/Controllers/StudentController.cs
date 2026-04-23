using _7_NetCORE.Models;
using _7_NetCORE.RepoServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _7_NetCORE.Controllers
{
    public class StudentController : Controller
    {
        public IStudentRepository StudentRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }

        public StudentController(IStudentRepository studentRepository, IDepartmentRepository departmentRepository)
        {
            StudentRepository = studentRepository;
            DepartmentRepository = departmentRepository;
        }
        
        public ActionResult Index()
        {
            return View(StudentRepository.GetAll() );
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View(StudentRepository.GetDetails(id));
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            ViewBag.Depts = DepartmentRepository.GetAll();
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        public ActionResult Create(Student St)
        {
            ViewBag.Depts = DepartmentRepository.GetAll();

            if (ModelState.IsValid)
            {
                try
                {
                    StudentRepository.Insert(St);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(St);
                }
            }
            else
            {
                return View(St);
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Depts = DepartmentRepository.GetAll();

            return View(StudentRepository.GetDetails(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        public ActionResult Edit(Student St)
        {
            ViewBag.Depts = DepartmentRepository.GetAll();

            if (ModelState.IsValid)
            {
                try
                {
                    StudentRepository.UpdateStd(St);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(St);
                }
            }
            else
            {
                return View(St);
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
