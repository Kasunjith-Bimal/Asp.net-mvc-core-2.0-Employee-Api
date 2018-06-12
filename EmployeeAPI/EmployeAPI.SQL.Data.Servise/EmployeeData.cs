using EmployeeAPI.EmployeeAPI.SQL.Data.Servise.Interface;
using EmployeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.EmployeAPI.SQL.Data.Servise
{
    public class EmployeeData : IEmployeeData
    {
        EmployeeDbContext db = new EmployeeDbContext();
        public List<EemployeeDb> getAllEmployeeData()
        {
            return db.EemployeeDb.ToList();
        }
    }
}
