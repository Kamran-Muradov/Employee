using Interface_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice.Services.Interfaces
{
    public interface IemployeeService
    {
        Employee[] GetAll();
        Employee GetById(Employee[] employees, int? id);
    }
}
