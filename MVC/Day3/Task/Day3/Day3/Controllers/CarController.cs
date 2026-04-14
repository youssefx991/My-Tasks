using Day3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day3.Controllers
{
    public class CarController : Controller
    {
        public IActionResult GetAllCars()
        {
            ViewBag.Cars = CarList.Cars;
            return View();
        }
        public IActionResult SelectCarById(int id)
        {
            ViewBag.Car = CarList.Cars.FirstOrDefault(c => c.Num == id);
            return View();
        }
        public IActionResult CreateNewCar()
        {
            
            return View();
        }
        public IActionResult CreateNewCarSave(int Num, string Color, string Model, string Manufacturer)
        {
            bool check = CarList.Cars.Any(c => c.Num == Num);
            if (check)
            {
                ViewBag.Error = "Car with this number already exists.";
                return View("CreateNewCar");
            }
            CarList.Cars.Add(new Car { Num = Num, Color = Color, Model = Model, Manufacturer = Manufacturer });
            return RedirectToAction("GetAllCars");
        }
        public IActionResult EditCar(int id)
        {
            ViewBag.Car = CarList.Cars.FirstOrDefault(c => c.Num == id);
            return View();
        }
        public IActionResult EditSave(int Num, string Color, string Model, string Manufacturer)
        {
            Car? car = CarList.Cars.FirstOrDefault(c => c.Num == Num);
            if (car != null)
            {
                car.Color = Color;
                car.Model = Model;
                car.Manufacturer = Manufacturer;
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
    }
}
