using EmployeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.EmployeeAPI.SQL.Data.Servise.Interface
{
    public interface IEmployeeData
    {
        List<EemployeeDb> getAllEmployeeData();

        EemployeeDb getEmployeeNameDetils(string name);

        List<EemployeeDb> getSeachEmployees(string searchstring);

        EemployeeDb getEmployeeById(int id);

        void addEmployee(EemployeeDb employeeobj);
        void updateEmployee(EemployeeDb employeeobj);

        void deleteEmployee(int employeeobj);
    }
}
