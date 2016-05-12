using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Lib2.Controllers
{
    public class BookDetailController : Controller
    {
        //
        // GET: /BookDetail/
        public ActionResult Index()
        {
            return View();
        }

        [Route("BookDetail/Smth/{id}")]
        public ActionResult Smthng(int id)
        {
            //return string.Format("User id: {0}", id);
            return View("id");
        }
	}
}