using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineCMS.Models;
using System.Diagnostics;
using System.Linq;
using OnlineCMS.Data;

namespace OnlineCMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _db = dbContext;
        }

        public IActionResult Index()
        {
            var page = _db.Pages.FirstOrDefault(x => x.Title == "Home");
            return View(page);
        }

        public IActionResult Privacy()
        {
            var page = _db.Pages.FirstOrDefault(x => x.Title == "PrivacyPolicy");
            return View(page);
        }

        public IActionResult Blog(int blogId)
        {
            var blog = _db.Blogs.FirstOrDefault(x => x.Id == blogId);
            return View(blog);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
