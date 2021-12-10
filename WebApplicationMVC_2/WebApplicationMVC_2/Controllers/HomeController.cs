using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC_2.Models;

namespace WebApplicationMVC_2.Controllers
{
    public class HomeController : Controller
    {
        UniversityContext db;
        public HomeController(UniversityContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
