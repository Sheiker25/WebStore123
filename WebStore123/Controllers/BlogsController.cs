using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore123.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult WebStoreBlog() => View();
    }
}
