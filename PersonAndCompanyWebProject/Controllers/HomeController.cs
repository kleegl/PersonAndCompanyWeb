using Microsoft.AspNetCore.Mvc;
using PersonAndCompanyWebProject.Databases;

namespace PersonAndCompanyWebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
