using PersonAndCompanyWebProject.Models;
using PersonAndCompanyWebProject.Databases;

namespace PersonAndCompanyWebProject.Repositories.CompanyRepos
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _dbContext;

        public CompanyRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Company> ShowAll()
        {
            return _dbContext.Companies.ToList();
        }

        public bool Create(Company company)
        {
            try
            {
                _dbContext.Companies.Add(company);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
