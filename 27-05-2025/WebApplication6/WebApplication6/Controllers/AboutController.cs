using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
