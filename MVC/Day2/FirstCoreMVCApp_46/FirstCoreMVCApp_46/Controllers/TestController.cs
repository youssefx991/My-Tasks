using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCApp_46.Controllers
{
    public class TestController : Controller
    {
        //Action: must be public and non static method of controller class
        public string testAction()
        {
            return "Hello test Action ..........";
        }


        //Types Action can return:
        //1. Content "String" (text or anything "toString")
        //2. Json
        //3. Void
        //4. View "Html"
        //5. File
        //6. Not Found

        //Parent Class --> ActionResult --> IActionResult

        public ContentResult testContent()
        {
            //Declare Object
            //Set Data
            //Return

            ContentResult ContentResultObj = new ContentResult();
            ContentResultObj.Content = "Hello MVC Course ..........";
            return ContentResultObj;
        }

        public JsonResult testJson()
        {
            //Declare Object
            //Set Data
            //Return

            JsonResult JsonResultObj = new JsonResult(new {ID = 11, Name= "Mona"});
            return JsonResultObj;
        }

        public ViewResult testView()
        {
            //Declare Object
            //Set Data
            //Return

            ViewResult ViewResultObj = new ViewResult();
            ViewResultObj.ViewName = "testView";
            return ViewResultObj;
        }

        public IActionResult testData(int value)
        {
            if (value > 0)
            {
                ViewResult ViewResultObj = new ViewResult();
                ViewResultObj.ViewName = "testView";
                return ViewResultObj;
            }
            else
            {
                ContentResult ContentResultObj = new ContentResult();
                ContentResultObj.Content = "Negative Number!!!!!";
                return ContentResultObj;
            }
        }


        public IActionResult newTestContent()
        {
            //Declare Object
            //Set Data
            //Return

            //ContentResult ContentResultObj = new ContentResult();
            //ContentResultObj.Content = "Hello MVC Course ..........";
            //return ContentResultObj;

            return Content("Hello MVC Course ..........");

        }

        public IActionResult newTestJson()
        {
            return Json(new { ID = 11, Name = "Mona" });
        }

        public IActionResult newTestView()
        {
            
            ViewData["msg"] = "Hello View Data";

            ViewData["BookNames"] = new List<string>() { "C#", "DB", "MVC" };

            return View();

            //return View("testView");
        }

    }
}
