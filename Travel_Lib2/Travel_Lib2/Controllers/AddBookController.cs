using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Lib2.Controllers
{
    public class AddBookController : Controller
    {
        //
        // GET: /AddBook/
        public ActionResult Index()
        {
            ViewBag.Title = "Добавление новой книги";

            return View();
        }
	}
}