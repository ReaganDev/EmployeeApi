using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    public class MockEmployee : IEmployee
    {
         List<Employees> employees = new()
        {
            new Employees
            {
                FirstName = "Reagan",
                LastName = "Reuben",
                Age = 26
            },
            new Employees
            {
                FirstName = "Precious",
                LastName = "Reuben",
                Age = 24
            },
            new Employees
            {
                FirstName = "Divine",
                LastName = "Reuben",
                Age = 21
            },
            new Employees
            {
                FirstName = "Success",
                LastName = "Reuben",
                Age = 18
            }
        };

        public Employees AddEmployee(Employees employee)
        {
            employee.Id = Guid.NewGuid().ToString();
             employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employees employee)
        {
            employees.Remove(employee);
        }

        public List<Employees> GetAllEmployees()
        {
            return employees;
        }

        public Employees GetEmployeeById(string id)
        {
            var employee = employees.SingleOrDefault(x => x.Id == id);
            return employee;
        }

        public Employees UpdateEmployee(Employees employee, string id)
        {
            var existing = GetEmployeeById(id);
            existing.FirstName = employee.FirstName;
            existing.LastName = employee.LastName;
            existing.Age = employee.Age;
            return existing;
        }
    }
}
