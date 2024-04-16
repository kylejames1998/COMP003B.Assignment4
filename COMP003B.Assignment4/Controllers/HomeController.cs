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
            return View("Register");
        }

        // POST: Home/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThankYou(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // if all data is valid, it redirects to the ThankYou page
                return View("ThankYou", model); // changed from RedirectToAction to View (maybe keep?)
            }

            // if data is not valid, it returns to the Register page so that it can be reattempted
            return View("Register", model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
