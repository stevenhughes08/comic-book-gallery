using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {              //typename         //fieldname
        private ComicBookRepository _comicBookRepository = null;
        //Below is a constuctor. It does not have a return type and name matches the class name. 
        public ComicBooksController()
        {   
            _comicBookRepository = new ComicBookRepository();
        }
        
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);

        }
                 



                // ViewBag.SeriesTitle = "The Amazing Spider-Man";
                // ViewBag.IssueNumber = 700;
                // ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
                // ViewBag.Artists = new string[]
                // {
                //     "Script: Dan Slott",
                //     "Pencils: Humberto Ramos",
                //     "Inks: Victor Olazaba",
                //     "Colors: Edgar Delgado",
                //     "Letters: Chris Eliopoulos"
                //};

           

        
    }
}