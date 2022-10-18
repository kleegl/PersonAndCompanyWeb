using Microsoft.AspNetCore.Mvc;

using PersonAndCompanyWebProject.Repositories.CompanyRepos;
using PersonAndCompanyWebProject.Models;

namespace PersonAndCompanyWebProject.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public IActionResult ShowAll()
        {
            return View(_companyRepository.ShowAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Company newCompany)
        {
            _companyRepository.Create(newCompany);
            Response.StatusCode = 200;
            return View("ShowAll");
        }
    }
}
