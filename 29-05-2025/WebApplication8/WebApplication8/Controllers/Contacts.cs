using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class Contacts : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
