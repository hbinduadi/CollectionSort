using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SortCollection.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Random Rnd = new Random();
            List<int> list = new List<int>();

            for (int counter = 1; counter <= 5; counter++)
                list.Add(Rnd.Next(1, 100));

            list.Sort();
            ViewBag.collection = list;
            return View();
        }
    }
}