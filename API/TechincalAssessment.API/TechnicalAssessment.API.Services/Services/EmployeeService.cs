using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechnicalAssessment.API.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly TechnicalAssssment.API.Repository.IEmployeeRepository _employeeRepository;

        public EmployeeService(TechnicalAssssment.API.Repository.IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> AddNewEmployeeAsync(Models.Employee employee)
        {
            var newEmployee = ViewToDbModelMapper.EmployeeMapper.Map(employee);
            return await _employeeRepository.AddNewEmployeeAsync(newEmployee);
        }

        public async Task<Models.Employee> ListEmployeeDetailsAsync(int employeeID)
        {
            var employeeDetails = await _employeeRepository.ListEmployeeDetailsAsync(employeeID);
            return DbToViewModelMapper.EmployeeMapper.Map(employeeDetails);
        }

        public async Task<IEnumerable<Models.Employee>> ListEmployeesAsync()
        {
            var employeeList = await _employeeRepository.ListEmployeesAsync();
            return DbToViewModelMapper.EmployeeMapper.Map(employeeList);
        }

        public async Task<int> UpdateEmployeeDetailsAsync(int ExistingEmployeeID, Models.Employee employeeUpdatedDetails)
        {
            var employeeNewUpdatedDetails = ViewToDbModelMapper.EmployeeMapper.Map(employeeUpdatedDetails);

            return await _employeeRepository.UpdateEmployeeDetailsAsync(ExistingEmployeeID, employeeNewUpdatedDetails);
        }
    }
}
