using Microsoft.AspNetCore.Mvc;
using Nikhil_PART2_PROG6212_CMCSF.Models;
using System.Diagnostics;

namespace Nikhil_PART2_PROG6212_CMCSF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }







        // This method handles HTTP requests to the 'Index' action of the controller.
        public IActionResult Index()
        {
            // Returns the 'Index' view to be rendered and displayed in the browser.
            return View();
        }










        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
