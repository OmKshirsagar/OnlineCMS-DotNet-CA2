using Microsoft.AspNetCore.Mvc;
using OnlineCMS.Data;
using System.Linq;

namespace OnlineCMS.Controllers
{
    public class AboutMeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AboutMeController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public IActionResult Index()
        {
            var page = _db.Pages.FirstOrDefault(x => x.Title == "AboutMe");

            return View(page);
        }


    }
}
