using Day4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day4.Controllers
{
    public class CarController : Controller
    {
        public IActionResult GetAllCars()
        {

            return View(CarList.Cars);
        }
        public IActionResult SelectCarById(int id)
        {

            return View(CarList.Cars.FirstOrDefault(c => c.Num == id));
        }
        [HttpGet]
        public IActionResult CreateNewCar()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateNewCar(Car car)
        {
            bool check = CarList.Cars.Any(c => c.Num == car.Num);
            if (check)
            {
                ViewBag.Error = "Car with this number already exists.";
                return View("CreateNewCar");
            }
            CarList.Cars.Add(car);
            return RedirectToAction("GetAllCars");
        }
        [HttpGet]
        public IActionResult EditCar(int id)
        {
            return View(CarList.Cars.FirstOrDefault(c => c.Num == id));
        }
        [HttpPost]
        public IActionResult EditCar(Car car)
        {
            Car? existingCar = CarList.Cars.FirstOrDefault(c => c.Num == car.Num);
            if (existingCar != null)
            {
                existingCar.Color = car.Color;
                existingCar.Model = car.Model;
                existingCar.Manufacturer = car.Manufacturer;
            }
            return RedirectToAction("GetAllCars");
        }
        public IActionResult DeleteCar(int id)
        {
            Car? car = CarList.Cars.FirstOrDefault(c => c.Num == id);
            if (car != null)
                CarList.Cars.Remove(car);

            return RedirectToAction("GetAllCars");
        }
        public IActionResult TestInline()
        {
            return View();
        }
    }
}
