using PersonAndCompanyWebProject.Models;

namespace PersonAndCompanyWebProject.Repositories.CompanyRepos
{
    public interface ICompanyRepository
    {
        public List<Company> ShowAll();
        public bool Create(Company newCompany);
    }
}
