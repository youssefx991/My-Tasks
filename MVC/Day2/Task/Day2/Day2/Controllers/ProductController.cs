using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ShowProductDetails(string Name, string Picture, double Price, string Description)
        {
            ViewData["Name"] = Name;
            ViewData["Picture"] = Picture;
            ViewData["Price"] = Price;
            ViewData["Description"] = Description;

            return View("ProductDetails");
        }

        /*
         * /Product/ShowProductDetails?name=Cane%20Juice&picture=juice.png&price=15&description=Fresh%20natural%20cane%20juice%20made%20from%20pressed%20sugarcane,%20rich%20in%20energy%20and%20perfect%20for%20refreshment%20on%20hot%20days
         */
    }
}
