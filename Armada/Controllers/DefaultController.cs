using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Armada.Database;

namespace Armada.Controllers
{
    public class DefaultController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Default
        public ActionResult Index()
        {
            

            return View();
        }
    }
}