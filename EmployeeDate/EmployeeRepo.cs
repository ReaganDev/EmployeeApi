using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    public class EmployeeRepo : IEmployee
    {
        private readonly DemoContext _context;

        public EmployeeRepo(DemoContext context)
        {
            _context = context;
        }

        public Employees AddEmployee(Employees employee)
        {
            employee.Id = Guid.NewGuid().ToString();
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employees employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public List<Employees> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employees GetEmployeeById(string id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public Employees UpdateEmployee(Employees employee, string id)
        {
            var existing = GetEmployeeById(id);
            existing.FirstName = employee.FirstName;
            existing.LastName = employee.LastName;
            existing.Age = employee.Age;
            _context.SaveChanges();
            return existing;
        }
    }
}
