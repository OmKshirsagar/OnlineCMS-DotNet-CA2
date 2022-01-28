using Microsoft.AspNetCore.Mvc;

namespace OnlineCMS.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
