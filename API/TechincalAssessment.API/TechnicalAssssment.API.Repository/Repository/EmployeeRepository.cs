using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechnicalAssssment.API.Repository
{
    public class EmployeeRepository: BaseRepository, IEmployeeRepository
    {

        public EmployeeRepository(AppDbContext context) : base(context) { }

        public async Task<int> AddNewEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee.EmployeeID;
        }

        public async Task<Employee> ListEmployeeDetailsAsync(int employeeID)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeID == employeeID);
        }

        public async Task<IEnumerable<Employee>> ListEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<int> UpdateEmployeeDetailsAsync(int ExistingEmployeeID, Employee employeeUpdatedDetails)
        {
            var existingEmployee = await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeID == ExistingEmployeeID);

            existingEmployee.FirstName = employeeUpdatedDetails.FirstName;
            existingEmployee.LastName = employeeUpdatedDetails.LastName;
            existingEmployee.Age = employeeUpdatedDetails.Age;
            existingEmployee.EmploymentStartDate = employeeUpdatedDetails.EmploymentStartDate;
            existingEmployee.EmploymentEndDate = employeeUpdatedDetails.EmploymentEndDate;
            existingEmployee.JobTitle = employeeUpdatedDetails.JobTitle;

            _context.SaveChanges();

            return existingEmployee.EmployeeID;
        }
    }
}
