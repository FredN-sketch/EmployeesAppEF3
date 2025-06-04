using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Infrastructure.Persistance;
using EmployeesApp.Infrastructure.Persistance.Repositories;

namespace EmployeesApp.Infrastructure;
public class UnitOfWork(
    ApplicationContext applicationContext,
    IEmployeeRepository employeeRepository,
    ICompanyRepository companyRepository) : IUnitOfWork
{
    public IEmployeeRepository Employees { get; } = employeeRepository;
    public ICompanyRepository Companies { get; } = companyRepository;

    public async Task PersistAsync()
    {
        // call save changes here
        await applicationContext.SaveChangesAsync();
    }
}
