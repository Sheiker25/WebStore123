using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore123.Models;

namespace WebStore123.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index() => View ();



        public IActionResult About() => View();

        public IActionResult Catalog() => View();

    }
}
