using EmployeesApp.Infrastructure.Persistance.Repositories;

namespace EmployeesApp.Application.Employees.Interfaces;
public interface IUnitOfWork
{
    IEmployeeRepository Employees { get; }
    ICompanyRepository Companies { get; }
    Task PersistAsync();
}
