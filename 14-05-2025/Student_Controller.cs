using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public String Index()
        {
            return "This is the index page";
        }
        public String GetStudentName()
        {
            return "The student name is Janani G";
        }
        public long GetStudentPhone()
        {
            return 7397330875;
        }
    }
}
