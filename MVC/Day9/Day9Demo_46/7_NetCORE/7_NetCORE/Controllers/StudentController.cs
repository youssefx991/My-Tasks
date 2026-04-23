using _7_NetCORE.Models;
using _7_NetCORE.RepoServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _7_NetCORE.Controllers
{
    //DTO

    // localhost:port/Student/Index  ==> Request
    // localhost:port/Student/Details/5  ==> Request
    // localhost:port/Student/Delete/3  ==> Request

    //[Authorize]
    [Route("Std")]
    public class StudentController : Controller
    {
        //StudentRepoService studentRepo = new StudentRepoService();

        //request service of type IStudentRepository, create & inject obj of class "StudentRepoService" 

        public IStudentRepository StudentRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }

        public StudentController(IStudentRepository studentRepository, IDepartmentRepository departmentRepository)
        {
            StudentRepository = studentRepository;
            DepartmentRepository = departmentRepository;
        }

        [Route("~/bye")]
        public ActionResult goodbyeFun()
        {
            return Content("Goodbye MVC...........");
        }

        // GET: StudentController
        //[Authorize]

        [Route("AllStd")]
        [Route("AllData")]
        [Route("")]
        public ActionResult Index()
        {
            return View(StudentRepository.GetAll());
        }

        // GET: StudentController/Details/5
        [Route("Std/{id:int:min(3)}")]
        public ActionResult Details(int id)
        {
            return View(StudentRepository.GetDetails(id));
        }

        // GET: StudentController/Create
        [AllowAnonymous]
        [Route("Crt")]
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
                    return View();
                }
            }
            return View(St);
        }

        // GET: StudentController/Edit/5

        [Route("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            ViewBag.Depts = DepartmentRepository.GetAll();

            return View(StudentRepository.GetDetails(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            ViewBag.Depts = DepartmentRepository.GetAll();

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
        [Route("Del/{id}")]

        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
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
