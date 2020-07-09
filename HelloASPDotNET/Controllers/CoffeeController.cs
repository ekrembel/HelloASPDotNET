using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    public class CoffeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<string> coffeeList = new List<string> { "French Roast", "Expresso", "Kopi Luwak", "Instant" };
            ViewBag.coffees = coffeeList;
            return View();
        }
        
    }
}
