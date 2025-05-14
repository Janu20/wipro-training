using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public String Index()
        {
            return "This is the Employee index";
        }

        public string FirstName()
        {
            return "My First Name is Janani";
        }
        public string LastName()
        {
            return "My Last Name is G";
        }
    }
}
