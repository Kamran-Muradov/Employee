using Interface_Practice.Services;
using Interface_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice.Controllers
{
    public class EmployeeController
    {
        private readonly IemployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetAll()
        {
            var employees = _employeeService.GetAll();

            foreach (var employee in employees)
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Age} {employee.Address} {employee.Email} {employee.Birthday.ToString("MM/dd/yyyy")}";
                Console.WriteLine(result);
            }
        }

        public void GetById(int? id)
        {
            var employee = _employeeService.GetById(_employeeService.GetAll(), id);

            if (id == null)
            {
                Console.WriteLine("No id specified");
                return;
            }
            else
            {
                Console.WriteLine(employee != null ? $"{employee.Name} {employee.Surname} {employee.Age} {employee.Address} {employee.Email} {employee.Birthday.ToString("MM/dd/yyyy")}" : "Employee notfound");
            }

        }
    }
}
