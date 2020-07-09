using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<div style='text-align: center; margin-top: 50px;'>" +
                "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name'>" +
                "<select id='lang' name='lang'>" +
                    "<option value='en' >English</option>" +
                    "<option value='it' >Italian</option>" +
                    "<option value='nl' >Dutch</option>" +
                    "<option value='tr' >Turkish</option>" +
                    "<option value='es' >Spanish</option>" +
                "</select>" +
                "<input type='submit' value='Greet me'>" +
                "</form>" +
                "</div>";
            return Content(html, "text/html");
        }

        // GET: /hello/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name, string lang)
        {
            string message = CreateMessage(name, lang);
            return Content(message, "text/html");
        }

        public static string CreateMessage(string name, string lang)
        {
            List<string> message = new List<string>();
            if (lang == "en")
            {
                message.Add("<h1 style='text-align: center; padding-top: 50px;'>Welcome to my app, " + name + "!</h1>");
            }
            else if (lang == "it")
            {
                message.Add("<h1 style='text-align: center; padding-top: 50px; color: green;'>Benvenuti nella mia domanda, " + name + "!</h1>");
            }
            else if (lang == "nl")
            {
                message.Add("<h1  style='text-align: center; padding-top: 50px; color: red;'>Welkom bij mijn aanvraag, " + name + "!</h1>");
            }
            else if (lang == "tr")
            {
                message.Add("<h1 style='text-align: center; padding-top: 50px; color: blue;'>Uygulamama hos geldin, " + name + "!</h1>");
            }
            else if (lang == "es")
            {
                message.Add("<h1 style='text-align: center; padding-top: 50px; color: yellow;'>Bienvenido a mi solicitud, " + name + "!</h1>");
            }
            if (message.Count > 0)
            {
                return message[0];
            }
            return "<h1>Welcome to my app, world!</h1>";
        }
    }
}
