using Day8.Models;
using Day8.RepoServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day8.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository ProductRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        public ProductController(IProductRepository productRepository, ICustomerRepository customerRepository)
        {
            ProductRepository = productRepository;
            CustomerRepository = customerRepository;
        }


        // GET: ProductController
        public ActionResult Index()
        {
            return View(ProductRepository.GetAll());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View(ProductRepository.GetDetails(id));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewBag.CustomersList = new SelectList(CustomerRepository.GetAll(), "ID", "Name");
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            ViewBag.CustomersList = new SelectList(CustomerRepository.GetAll(), "ID", "Name");

            if (ModelState.IsValid)
            {
                ProductRepository.Insert(product);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(product);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.CustomersList = new SelectList(CustomerRepository.GetAll(), "ID", "Name");

            return View(ProductRepository.GetDetails(id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            ViewBag.CustomersList = new SelectList(CustomerRepository.GetAll(), "ID", "Name");

            if (ModelState.IsValid)
            {
                ProductRepository.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(product);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ProductRepository.GetDetails(id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                ProductRepository.DeleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(ProductRepository.GetDetails(id));
            }
        }
    }
}
