using Microsoft.AspNetCore.Mvc;
using PersonAndCompanyWebProject.Repositories.CompanyRepos;

namespace PersonAndCompanyWebProject.Controllers
{
    public class CompanyController : Controller
    {
        //private readonly ICompanyRepository _companyRepository;

        //public CompanyController(ICompanyRepository companyRepository)
        //{
        //    _companyRepository = companyRepository;
        //}

        //[HttpGet]
        //public IActionResult ShowAll()
        //{
        //    return View(_companyRepository.ShowAll());
        //}

        [HttpGet]
        public IActionResult ShowAll()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
