using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /hello/welcome
       
        [HttpPost]
        [Route("/hello")]
        public IActionResult Hello(string name, string lang)
        {
            ViewBag.name = name;
            ViewBag.language = lang;
            return View();
        }

        public static string CreateMessage(string name, string lang)
        {
            List<string> message = new List<string>();
            if (lang == "en")
            {
                message.Add("Welcome to my app, " + name + "!");
            }
            else if (lang == "it")
            {
                message.Add("Benvenuti nella mia domanda, " + name + "!");
            }
            else if (lang == "nl")
            {
                message.Add("Welkom bij mijn aanvraag, " + name + "!");
            }
            else if (lang == "tr")
            {
                message.Add("Uygulamama hos geldin, " + name + "!");
            }
            else if (lang == "es")
            {
                message.Add("Bienvenido a mi solicitud, " + name + "!");
            }
            if (message.Count > 0)
            {
                return message[0];
            }
            return "Welcome to my app, world!";
        }
    }
}
