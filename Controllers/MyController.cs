using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmpty.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Home()
        {
            ViewBag.Date = DateTime.Now.ToString();
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "Lucian testar viewbag";
            ViewBag.Date = DateTime.Now.ToString();
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.Date = DateTime.Now.ToString();
            return View();
        }
        public IActionResult Projects()
        {
            ViewBag.Date = DateTime.Now.ToString();
            return View();
        }
    }

}
