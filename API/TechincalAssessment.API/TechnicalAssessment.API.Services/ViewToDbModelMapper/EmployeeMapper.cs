using System;
using System.Collections.Generic;

namespace TechnicalAssessment.API.Services.ViewToDbModelMapper
{
    public static class EmployeeMapper
    {
        internal static TechnicalAssssment.API.Repository.Employee Map(Models.Employee employee)
        {
            TechnicalAssssment.API.Repository.Employee _employee = null;

            if (employee != null)
            {
                _employee = new TechnicalAssssment.API.Repository.Employee();
                _employee.EmployeeID = employee.EmployeeID;
                _employee.FirstName = employee.FirstName;
                _employee.LastName = employee.LastName;
                _employee.Age = employee.Age;
                _employee.EmploymentEndDate = ParseDateTime(employee.EmploymentEndDate);
                _employee.EmploymentStartDate = Convert.ToDateTime(ParseDateTime(employee.EmploymentStartDate));
                _employee.JobTitle = employee.JobTitle;
            }

            return _employee;
        }

        private static DateTime? ParseDateTime(string dateTime)
        {
            DateTime? parsedDateTime = null;
            if (String.IsNullOrEmpty(dateTime))
                return parsedDateTime;

            parsedDateTime = Convert.ToDateTime(dateTime);

            return parsedDateTime;
        }


        internal static List<TechnicalAssssment.API.Repository.Employee> Map(IEnumerable<Models.Employee> employees)
        {
            List<TechnicalAssssment.API.Repository.Employee> _employee = null;

            if (employees != null)
            {
                _employee = new List<TechnicalAssssment.API.Repository.Employee>();
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
