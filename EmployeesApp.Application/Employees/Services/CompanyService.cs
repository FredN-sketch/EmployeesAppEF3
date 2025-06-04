using EmployeesApp.Application.Employees.Interfaces;

namespace EmployeesApp.Application.Employees.Services;
public class CompanyService(IUnitOfWork unitOfWork) : ICompanyService
{
    public async Task DeleteAsync(int id)
    {
        // delete all employees first
        await unitOfWork.Employees.DeleteEmployeesFromCompanyAsync(id);

        // delete company
        await unitOfWork.Companies.DeleteAsync(id);
    }
}
