using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Infrastructure.Persistance.Repositories
{
    public class CompanyRepository(ApplicationContext context) : ICompanyRepository
    {
        public async Task AddAsync(Company company)
        {
            await context.Companies.AddAsync(company);
            await context.SaveChangesAsync(); // Inte glömma!
        }

        // TODO: Added AsNoTracking() & Include()
        public async Task<Company[]> GetAllAsync() =>
            await context.Companies.AsNoTracking().Include(c => c.Employees).ToArrayAsync();

        public async Task<Company?> GetByIdAsync(int id) => await context.Companies
            .FindAsync(id);
    }
}
