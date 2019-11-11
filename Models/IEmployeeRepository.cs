﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        Employee AddEmployee(Employee e);
        Employee Update(Employee employeeToUpdate);
        Employee Delete(int id);
    }
}
