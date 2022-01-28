using Microsoft.AspNetCore.Mvc;
using OnlineCMS.Data;
using System.Linq;

namespace OnlineCMS.Controllers
{
    public class ContactMeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ContactMeController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public IActionResult Index()
        {
            var page = _db.Pages.FirstOrDefault(x => x.Title == "ContactMe");

            return View(page);
        }


    }
}
