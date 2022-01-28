using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCMS.Data;
using OnlineCMS.Models;

namespace OnlineCMS.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> EditPage(string title)
        {
            var page = await _db.Pages.FirstOrDefaultAsync(x => x.Title == title);
            if (page == null)
            {
                page = new Page();
                page.Title = title;

                _db.Pages.Add(page);
                _db.SaveChanges();
            }

            return View(page);
        }

        [HttpPost]
        public async Task<IActionResult> SavePage(string title, string content)
        {
            var page = await _db.Pages.FirstOrDefaultAsync(x => x.Title == title);
            if (page == null)
            {
                return View("Error");
            }

            page.Content = content;
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
