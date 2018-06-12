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

        public void addEmployee(EemployeeDb employeeobj)
        {
            db.EemployeeDb.Add(employeeobj);
            db.SaveChanges();

        }

        public void deleteEmployee(int employeeobj)
        {
            EemployeeDb delobj = db.EemployeeDb.Where(x => x.EmployeeId == employeeobj).FirstOrDefault();

            db.Entry(delobj).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public List<EemployeeDb> getAllEmployeeData()
        {
            return db.EemployeeDb.ToList();
        }

        public EemployeeDb getEmployeeById(int id)
        {
            return db.EemployeeDb.Where(x => x.EmployeeId == id).FirstOrDefault();
        }
        public EemployeeDb getEmployeeNameDetils(string name)
        {
            return db.EemployeeDb.Where(x => x.EmployeeName == name).FirstOrDefault();
        }

        public List<EemployeeDb> getSeachEmployees(string searchstring)
        {
            return db.EemployeeDb.Where(x => x.EmployeeName.Contains(searchstring)).ToList();
        }

        public void updateEmployee(EemployeeDb employeeobj)
        {
            EemployeeDb empobj = db.EemployeeDb.Where(x => x.EmployeeId.Equals(employeeobj.EmployeeId)).FirstOrDefault();

            empobj.EmployeeAge = employeeobj.EmployeeAge;
            empobj.EmployeeName = employeeobj.EmployeeName;
            empobj.EmployeeTelephone = employeeobj.EmployeeTelephone;
            empobj.EmployeeId = employeeobj.EmployeeId;

            db.Entry(empobj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

        }
    }
}
