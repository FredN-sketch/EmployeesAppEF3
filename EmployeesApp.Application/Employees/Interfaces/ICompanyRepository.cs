using EmployeesApp.Domain.Entities;

namespace EmployeesApp.Infrastructure.Persistance.Repositories
{
    public interface ICompanyRepository
    {
        Task AddAsync(Company company);
        Task<Company[]> GetAllAsync();
        Task<Company?> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}