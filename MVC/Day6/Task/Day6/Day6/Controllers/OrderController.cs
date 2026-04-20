using Day6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Day6.Controllers
{
    public class OrderController : Controller
    {
        private Day6Context Context = new Day6Context();
        // GET: OrderController
        public ActionResult Index()
        {
            ViewBag.CustomersList = new SelectList(Context.Customers.ToList(), "ID", "Email", -1);
            return View(Context.Orders.Include(o=>o.Customer).ToList());
        }
        [HttpPost]
        public ActionResult Index(int customerId)
        {
            ViewBag.CustomersList = new SelectList(Context.Customers.ToList(), "ID", "Email", customerId);
            if (customerId != -1)
            {
                return View(Context.Orders.Include(o => o.Customer).Where(o=>o.CustID == customerId).ToList());
            }

            return View(Context.Orders.Include(o => o.Customer).ToList());
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View(Context.Orders.Include(o => o.Customer).FirstOrDefault(c => c.ID == id));
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            ViewBag.CustomersList = new SelectList(Context.Customers.ToList(), "ID", "Email", -1);
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order Order)
        {
            ViewBag.CustomersList = new SelectList(Context.Customers.ToList(), "ID", "Email", -1);
            if (ModelState.IsValid)
            {
                Context.Orders.Add(Order);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(Order);
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.CustomersList = new SelectList(Context.Customers.ToList(), "ID", "Email", -1);
            return View(Context.Orders.Include(o => o.Customer).FirstOrDefault(c => c.ID == id));
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order Order)
        {
            ViewBag.CustomersList = new SelectList(Context.Customers.ToList(), "ID", "Email", -1);
            if (ModelState.IsValid)
            {
                var EditedOrder = Context.Orders.Include(o => o.Customer).FirstOrDefault(o => o.ID == Order.ID);
                if (EditedOrder != null)
                {
                    EditedOrder.Date = Order.Date;
                    EditedOrder.TotalPrice = Order.TotalPrice;
                    EditedOrder.CustID = Order.CustID;
                    Context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(Order);
            }
            else
            {
                return View(Order);
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Context.Orders.Include(o => o.Customer).FirstOrDefault(c => c.ID == id));
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Order Order)
        {

            var DeletedOrder = Context.Orders.Include(o => o.Customer).FirstOrDefault(c => c.ID == Order.ID);
            if (DeletedOrder != null)
            {
                Context.Orders.Remove(DeletedOrder);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(Order);
            }
        }
    }
}
