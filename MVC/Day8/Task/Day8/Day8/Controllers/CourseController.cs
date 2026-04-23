using Day8.Models;
using Day8.RepoServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day8.Controllers
{
    public class CourseController : Controller
    {
        ICourseRepository CourseRepository { get; }
        public CourseController(ICourseRepository courseRepository)
        {
            CourseRepository = courseRepository;
        }

        // GET: CourseController
        public ActionResult Index()
        {
            return View(CourseRepository.GetAll());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View(CourseRepository.GetDetails(id));
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                CourseRepository.Insert(course);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(course);
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(CourseRepository.GetDetails(id));
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                CourseRepository.UpdateCourse(course);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(course);
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(CourseRepository.GetDetails(id));
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Course course)
        {
            try
            {
                CourseRepository.DeleteCourse(course.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(course);
            }
        }
    }
}
