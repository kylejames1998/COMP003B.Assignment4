using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP003B.Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // GET: Home/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: Home/Register
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Register(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // if all data is valid, it redirects to the ThankYou page
                return RedirectToAction("ThankYou", model);
            }

            return View("Register", model);
        }

        // GET: Home/ThankYou
        public IActionResult ThankYou(RegistrationViewModel model)
        {
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
