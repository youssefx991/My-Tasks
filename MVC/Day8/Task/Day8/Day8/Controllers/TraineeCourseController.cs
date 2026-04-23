using Day8.Models;
using Day8.RepoServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day8.Controllers
{
    public class TraineeCourseController : Controller
    {
        ITraineeCourseRepository TraineeCourseRepoService { get; }
        ITraineeRepository TraineeRepository { get; }
        ICourseRepository CourseRepository { get; }
        public TraineeCourseController(ITraineeCourseRepository traineeCourseRepoService, ITraineeRepository traineeRepository, ICourseRepository courseRepository)
        {
            TraineeCourseRepoService = traineeCourseRepoService;
            TraineeRepository = traineeRepository;
            CourseRepository = courseRepository;
        }
        // GET: TraineeCourseController
        public ActionResult Index()
        {
            return View(TraineeCourseRepoService.GetAll());
        }

        // GET: TraineeCourseController/Details/5
        public ActionResult Details(int traineeId, int courseId)
        {
            return View(TraineeCourseRepoService.GetDetails(traineeId, courseId));
        }

        // GET: TraineeCourseController/Create
        public ActionResult Create()
        {
            ViewBag.TraineeList = new SelectList(TraineeRepository.GetAll(), "ID", "Name");
            ViewBag.CourseList = new SelectList(CourseRepository.GetAll(), "ID", "Topic");
            return View();
        }

        // POST: TraineeCourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TraineeCourse traineeCourse)
        {
            ViewBag.TraineeList = new SelectList(TraineeRepository.GetAll(), "ID", "Name");
            ViewBag.CourseList = new SelectList(CourseRepository.GetAll(), "ID", "Topic");
            if (ModelState.IsValid)
            {
                TraineeCourseRepoService.Insert(traineeCourse);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(traineeCourse);
            }
        }

        // GET: TraineeCourseController/Edit/5
        public ActionResult Edit(int traineeId, int courseId)
        {
            ViewBag.TraineeList = new SelectList(TraineeRepository.GetAll(), "ID", "Name");
            ViewBag.CourseList = new SelectList(CourseRepository.GetAll(), "ID", "Topic");
            return View(TraineeCourseRepoService.GetDetails(traineeId, courseId));
        }

        // POST: TraineeCourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TraineeCourse traineeCourse)
        {
            ViewBag.TraineeList = new SelectList(TraineeRepository.GetAll(), "ID", "Name");
            ViewBag.CourseList = new SelectList(CourseRepository.GetAll(), "ID", "Topic");
            if (ModelState.IsValid)
            {
                TraineeCourseRepoService.UpdateTraineeCourse(traineeCourse);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(traineeCourse);
            }
        }

        // GET: TraineeCourseController/Delete/5
        public ActionResult Delete(int traineeId, int courseId)
        {
            return View(TraineeCourseRepoService.GetDetails(traineeId, courseId));
        }

        // POST: TraineeCourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int traineeId, int courseId, IFormCollection collection)
        {
            try
            {
                TraineeCourseRepoService.DeleteTraineeCourse(traineeId, courseId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(TraineeCourseRepoService.GetDetails(traineeId, courseId));
            }
        }
    }
}
