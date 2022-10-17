using Microsoft.AspNetCore.Mvc;

namespace PersonAndCompanyWebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
