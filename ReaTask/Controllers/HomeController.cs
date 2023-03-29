using Microsoft.AspNetCore.Mvc;
using ReaTask.Data;
using ReaTask.Models;
using System.Diagnostics;

namespace ReaTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ReaTaskDbContext _context;

        public HomeController(ILogger<HomeController> logger, ReaTaskDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["CategoryCount"] = _context.Categories.Count();
            ViewData["ProductCount"] = _context.Products.Count();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}