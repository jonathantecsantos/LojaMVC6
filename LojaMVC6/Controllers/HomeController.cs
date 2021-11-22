using LojaMVC6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LojaMVC6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}