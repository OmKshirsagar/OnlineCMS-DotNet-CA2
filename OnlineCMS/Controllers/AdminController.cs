using Microsoft.AspNetCore.Mvc;

namespace OnlineCMS.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
