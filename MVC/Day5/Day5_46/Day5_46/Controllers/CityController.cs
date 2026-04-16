using Day5_46.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Day5_46.Controllers
{
    public class CityController : Controller
    {
        CityDbContext Context = new CityDbContext();

        // GET: CityController
        public ActionResult Index()
        {
            //ViewBag.cnt
            ViewBag.cnt = new SelectList(Context.Countries.ToList(), "CountryID", "CountryName");

            return View(Context.Cities.Include(c => c.Cntry).ToList());
        }

        [HttpPost]
        public ActionResult Index(IFormCollection collection)
        {
            int selectedCountryId = int.Parse(collection["cntr"]);
            var slectedCitites = Context.Cities.Include(c => c.Cntry).Where(c => c.cID == selectedCountryId).ToList();

            ViewBag.cnt = new SelectList(Context.Countries.ToList(), "CountryID", "CountryName", selectedCountryId);

            return View(slectedCitites);
        }

        // GET: CityController/Details/5
        public ActionResult Details(int id)
        {
            return View(Context.Cities.Include(c => c.Cntry).FirstOrDefault(c => c.CityID == id));
        }

        // GET: CityController/Create
        public ActionResult Create()
        {
            ViewBag.cID = Context.Countries.ToList();
            return View();
        }

        // POST: CityController/Create
        [HttpPost]
        public ActionResult Create(City cty)
        {
            if (cty != null)
            {
                Context.Cities.Add(cty);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(cty);
            }
        }

        // GET: CityController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.cID = Context.Countries.ToList();
            return View(Context.Cities.Include(c => c.Cntry).FirstOrDefault(c => c.CityID == id));
        }

        // POST: CityController/Edit/5
        [HttpPost]
        public ActionResult Edit(City cty)
        {
            City editedCity = Context.Cities.FirstOrDefault(c => c.CityID == cty.CityID);
            if (editedCity != null)
            {
                editedCity.CityName = cty.CityName;
                editedCity.cID = cty.cID;
                Context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(cty);
            }
        }

        // GET: CityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Context.Cities.Include(c => c.Cntry).FirstOrDefault(c => c.CityID == id));
        }

        // POST: CityController/Delete/5
        [HttpPost]
        public ActionResult Delete(City cty)
        {
            if (cty != null)
            {
                City cityToDelete = Context.Cities.Include(c => c.Cntry).FirstOrDefault(c => c.CityID == cty.CityID);

                if (cityToDelete != null)
                {
                    Context.Cities.Remove(cityToDelete);
                    Context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(cty);
                }
            }
            else
            {
                return View(cty);
            }
        }
    }
}
