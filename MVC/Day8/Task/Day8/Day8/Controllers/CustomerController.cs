using Day8.Models;
using Day8.RepoServices;
using Day8.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day8.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerRepository CustomerRepository { get; }
        public CustomerController(ICustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
        }

        // GET: CustomerController
        public ActionResult Index() 
        {
            return View(CustomerRepository.GetAll());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            var customer = CustomerRepository.GetDetails(id);
            Product_Cust_ViewModel model = new Product_Cust_ViewModel() 
            {
                CustID = customer.ID,
                CustName = customer.Name,
                Products = customer.Products.ToList()
            };
            return View(model);
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
                CustomerRepository.Insert(customer);
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
            return View(CustomerRepository.GetDetails(id));
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                CustomerRepository.UpdateCustomer(customer);
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
            return View(CustomerRepository.GetDetails(id));
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                CustomerRepository.DeleteCustomer(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(CustomerRepository.GetDetails(id));
            }
        }
    }
}
