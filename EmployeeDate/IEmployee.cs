using EmployeeModel;
using System;
using System.Collections.Generic;

namespace EmployeeData
{
    public interface IEmployee
    {
        List<Employees> GetAllEmployees();

        Employees GetEmployeeById(string id);

        Employees AddEmployee(Employees employee);

        void DeleteEmployee(Employees employee);

        Employees UpdateEmployee(Employees employee, string id);
    }
}
