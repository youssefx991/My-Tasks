using Day9.Models;
using Day9.RepoServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day9.Controllers
{
    [Route("tracks")]
    public class TrackController : Controller
    {
        ITrackRepository TrackRepository { get; }
        ITraineeRepository TraineeRepository { get; }

        public TrackController(ITrackRepository trackRepository, ITraineeRepository traineeRepository)
        {
            TrackRepository = trackRepository;
            TraineeRepository = traineeRepository;
        }

        // GET: TrackController
        [Route("")]
        public ActionResult Index()
        {
            return View(TrackRepository.GetAll());
        }

        // GET: TrackController/Details/5
        [Route("details/{id:int:min(1)}")]
        public ActionResult Details(int id)
        {
            return View(TrackRepository.GetDetails(id));
        }

        // GET: TrackController/Create
        [Route("create")]
        public ActionResult Create()
        {
            ViewBag.TraineesList = new SelectList(TraineeRepository.GetAll(), "ID", "Name");
            return View();
        }

        // POST: TrackController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public ActionResult Create(Track track, int[] TraineeList)
        {
            if(ModelState.IsValid) 
            {
                //if (TraineeList != null && track != null)
                //{
                //    track.Trainees = new List<Trainee>();
                //    foreach (var traineeId in TraineeList)
                //    {
                //        var trainee = TraineeRepository.GetDetails(traineeId);
                //        if (trainee != null)
                //        {
                //            track.Trainees.ToList().Add(trainee);
                //        }
                //    }
                //}

                TrackRepository.Insert(track);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(track);
            }
        }

        // GET: TrackController/Edit/5
        [Route("edit/{id:int:min(1)}")]

        public ActionResult Edit(int id)
        {
            ViewBag.TraineesList = new SelectList(TraineeRepository.GetAll(), "ID", "Name");
            return View(TrackRepository.GetDetails(id));
        }

        // POST: TrackController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit/{id:int:min(1)}")]
        public ActionResult Edit(Track track)
        {
            if (ModelState.IsValid)
            {
                TrackRepository.UpdateTrack(track);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(track);
            }
        }

        // GET: TrackController/Delete/5
        [Route("delete/{id:int:min(1)}")]

        public ActionResult Delete(int id)
        {
            return View(TrackRepository.GetDetails(id));
        }

        // POST: TrackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("delete/{id:int:min(1)}")]

        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                TrackRepository.DeleteTrack(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(TrackRepository.GetDetails(id));
            }
        }
    }
}
