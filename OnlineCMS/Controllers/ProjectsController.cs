using Microsoft.AspNetCore.Mvc;
using OnlineCMS.Data;
using System.Linq;

namespace OnlineCMS.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProjectsController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public IActionResult Index()
        {
            var page = _db.Pages.FirstOrDefault(x => x.Title == "Projects");

            return View(page);
        }
    }
}
