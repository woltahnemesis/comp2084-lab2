using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Details method that takes the URL parameter
        public IActionResult Details(string category)
        {
            //ViewBag holds the temporary value
            ViewBag.category = category;
            return View();
        }
    }
}
