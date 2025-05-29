using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
