using Microsoft.AspNetCore.Mvc;
using PaulaPachecoHairStyle.Models;
using System.Diagnostics;

namespace PaulaPachecoHairStyle.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
