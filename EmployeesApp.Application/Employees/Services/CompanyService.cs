using EmployeesApp.Application.Employees.Interfaces;

namespace EmployeesApp.Application.Employees.Services;
public class CompanyService(IUnitOfWork unitOfWork) : ICompanyService
{
    public async Task DeleteAsync(int id)
    {
        // delete all employees first
        unitOfWork.Employees.DeleteEmployeesFromCompanyAsync(id);

        // delete company
        unitOfWork.Companies.DeleteAsync(id);
    }
}
