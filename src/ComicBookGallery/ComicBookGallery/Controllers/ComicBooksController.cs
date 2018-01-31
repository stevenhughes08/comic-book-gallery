using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            //Below lines have been commented out for the next lesson
            // if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            //{
            //    return Redirect("/");

            // }

            //return Content("Hello from the comic books controler");

            //Returning a view. 

            return View();
            
        }
    }
}