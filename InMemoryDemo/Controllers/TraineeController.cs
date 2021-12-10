using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using InMemoryRepository;

namespace CDE21ID009InMemoryDemo.Controllers
{
    public class TraineeController : Controller
    {
        private static TraineeRepo _traineeRepo;

        public TraineeController()
        {
            _traineeRepo = new TraineeRepo();
        }

        // GET: TraineeController
        public ActionResult Index()
        {
            List<Trainee> trainees = _traineeRepo.GetAllTrainees();
            return View(trainees);
        }

        // GET: TraineeController/Details/5
        public ActionResult Details(int id)
        {
            Trainee trainee = _traineeRepo.GetTrainee(id);
            return View(trainee);
        }

        // GET: TraineeController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: TraineeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainee trainee)
        {
            try
            {
                _traineeRepo.SaveTrainee(trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Trainee trainee = _traineeRepo.GetTrainee(id);
            return View(trainee);//Returns Views\Trainee\Edit.cshtml file
        }

        // POST: TraineeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Trainee TraineeModified)
        {
            try
            {
                _traineeRepo.UpdateTrainee(TraineeModified);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Trainee trainee = _traineeRepo.GetTrainee(id);
            return View(trainee);//Returns Views\Trainee\Delete.cshtml file
        }



        // POST: TraineeController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            try
            {
                _traineeRepo.DeleteTrainee(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
