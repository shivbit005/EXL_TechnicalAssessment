using System.Collections.Generic;
using System.Threading.Tasks;
using TechnicalAssessment.API.Services.Models;

namespace TechnicalAssessment.API.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> ListEmployeesAsync();
        Task<Employee> ListEmployeeDetailsAsync(int employeeID);
        Task<int> AddNewEmployeeAsync(Employee employee);
        Task<int> UpdateEmployeeDetailsAsync(int ExistingEmployeeID, Employee employeeUpdatedDetails);
    }
}
