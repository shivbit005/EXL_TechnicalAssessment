using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalAssessment.API.Services.DbToViewModelMapper
{
    public static class EmployeeMapper
    {
        internal static Models.Employee Map(TechnicalAssssment.API.Repository.Employee employee)
        {
            Models.Employee _employee = null;

            if(employee != null)
            {
                _employee = new Models.Employee();
                _employee.EmployeeID = employee.EmployeeID;
                _employee.FirstName = employee.FirstName;
                _employee.LastName = employee.LastName;
                _employee.Age = employee.Age;
                _employee.EmploymentEndDate = employee.EmploymentEndDate != null ? ParseDateTime(employee.EmploymentEndDate) : string.Empty;
                _employee.EmploymentStartDate = ParseDateTime(employee.EmploymentStartDate);
                _employee.JobTitle = employee.JobTitle;
            }

            return _employee;
        }

        private static string ParseDateTime(DateTime? dateTime)
        {
            var parsedDateTime = string.Empty;
            if (dateTime == null)
                return parsedDateTime;

            parsedDateTime = Convert.ToDateTime(dateTime).ToString("dd/MM/yyyy");

            return parsedDateTime;
        }


        internal static List<Models.Employee> Map(IEnumerable<TechnicalAssssment.API.Repository.Employee> employees)
        {
            List<Models.Employee> _employee = null;

            if (employees != null)
            {
                _employee = new List<Models.Employee>();
                foreach (var emp in employees)
                {
                    var employee = EmployeeMapper.Map(emp);
                    _employee.Add(employee);
                }
            }

            return _employee;
        }
    }
}
