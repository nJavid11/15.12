using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Website.Controllers
{
    public class ChefController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
