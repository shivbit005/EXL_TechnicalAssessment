using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechnicalAssssment.API.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> ListEmployeesAsync();
        Task<Employee> ListEmployeeDetailsAsync(int employeeID);
        Task<int> AddNewEmployeeAsync(Employee employee);
        Task<int> UpdateEmployeeDetailsAsync(int ExistingEmployeeID, Employee employeeUpdatedDetails);
    }
}
