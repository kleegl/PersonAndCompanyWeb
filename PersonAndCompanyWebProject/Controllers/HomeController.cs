using Microsoft.AspNetCore.Mvc;
using PersonAndCompanyWebProject.Databases;

namespace PersonAndCompanyWebProject.Controllers
{
    public class HomeController : Controller
    {
        //private readonly AppDbContext _dbContext;
        //public HomeController(AppDbContext db)
        //{
        //    _dbContext = db;
        //}
        public IActionResult Index() => View();
        //public IActionResult ShowAll()
        //{
        //    return View(_dbContext.Companies.ToList());
        //}
    }
}
