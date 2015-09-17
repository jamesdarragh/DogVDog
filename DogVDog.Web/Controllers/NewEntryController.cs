using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogVDog.Web.Controllers
{
    public class NewEntryController : Controller
    {
        // GET: NewEntry
        public ActionResult Index()
        {
            return View();
        }
    }
}