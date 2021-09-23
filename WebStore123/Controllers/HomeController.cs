using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore123.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View ();
        }

        public IActionResult SecondAction (string id)
        {
            return Content($"Second Action With parametr {id}");
        }
    }
}
