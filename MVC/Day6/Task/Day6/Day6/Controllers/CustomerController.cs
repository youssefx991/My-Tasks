using Day6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day6.Controllers
{
    public class CustomerController : Controller
    {
        private Day6Context Context = new Day6Context();
        // GET: CustomerController
        public ActionResult Index()
        {
            return View(Context.Customers.ToList());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View(Context.Customers.FirstOrDefault(c => c.ID == id));
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                Context.Customers.Add(customer);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(customer);
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Context.Customers.FirstOrDefault(c => c.ID == id));
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var EditedCustomer = Context.Customers.FirstOrDefault(c => c.ID == customer.ID);
                if (EditedCustomer != null)
                {
                    EditedCustomer.Name = customer.Name;
                    EditedCustomer.Email = customer.Email;
                    EditedCustomer.Gender = customer.Gender;
                    EditedCustomer.PhoneNum = customer.PhoneNum;
                    Context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(customer);
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Context.Customers.FirstOrDefault(c => c.ID == id));
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer customer)
        {

            var DeletedCustomer = Context.Customers.FirstOrDefault(c => c.ID == customer.ID);
            if (DeletedCustomer != null)
            {
                Context.Customers.Remove(DeletedCustomer);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(customer);
            }
        }
    }
}
