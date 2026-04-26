using Day9.Models;
using Day9.RepoServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day9.Controllers
{
    public class TraineeController : Controller
    {
        ITrackRepository TrackRepository { get; }
        ITraineeRepository TraineeRepository { get; }

        public TraineeController(ITrackRepository trackRepository, ITraineeRepository traineeRepository)
        {
            TrackRepository = trackRepository;
            TraineeRepository = traineeRepository;
        }

        // GET: TraineeController
        public ActionResult Index()
        {
            return View(TraineeRepository.GetAll());
        }

        // GET: TraineeController/Details/5
        public ActionResult Details(int id)
        {
            return View(TraineeRepository.GetDetails(id));
        }

        // GET: TraineeController/Create
        public ActionResult Create()
        {
            ViewBag.TrackList = new SelectList(TrackRepository.GetAll(), "ID", "Name");
            return View();
        }

        // POST: TraineeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainee trainee)
        {
            ViewBag.TrackList = new SelectList(TrackRepository.GetAll(), "ID", "Name");

            if (ModelState.IsValid)
            {
                TraineeRepository.Insert(trainee);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(trainee);
            }
        }

        // GET: TraineeController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.TrackList = new SelectList(TrackRepository.GetAll(), "ID", "Name");
            return View(TraineeRepository.GetDetails(id));
        }

        // POST: TraineeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Trainee trainee)
        {
            ViewBag.TrackList = new SelectList(TrackRepository.GetAll(), "ID", "Name");

            if (ModelState.IsValid)
            {
                TraineeRepository.UpdateTrainee(trainee);  
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(trainee);
            }
        }

        // GET: TraineeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(TraineeRepository.GetDetails(id));
        }

        // POST: TraineeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Trainee trainee)
        {
            try
            {
                TraineeRepository.DeleteTrainee(trainee.ID);    
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                Console.WriteLine("not valid");
                return View(trainee);
            }
        }
    }
}
