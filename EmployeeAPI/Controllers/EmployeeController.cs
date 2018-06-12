using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.EmployeeAPI.SQL.Data.Servise.Interface;
using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeData _employeeData;
        public EmployeeController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }
        // GET: api/<controller>
        [HttpGet]
        public List<EemployeeDb> Get()
        {
            return _employeeData.getAllEmployeeData();
        }

        //// GET api/<controller>/5
       
        [HttpGet("{id}", Name = "getnamedutels")]
        public EemployeeDb Get(string id)
        {
            return _employeeData.getEmployeeNameDetils(id);
        }
        [HttpGet("{id:int}")]
        public EemployeeDb Get(int id)
        {
            return _employeeData.getEmployeeById(id);
        }

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody]EemployeeDb value)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _employeeData.addEmployee(value);
        //    }
        //}
        //// POST api/<controller>
        [Route("AddUser")]
        [HttpPost]
        public void AddUser([FromBody]EemployeeDb obj)
        {
            if (ModelState.IsValid)
            {
                _employeeData.addEmployee(obj);
            }

        }
        [Route("SearchEmployee")]
        [HttpPost]
        public void SearchEmployee([FromBody]EemployeeDb obj)
        {
            if (ModelState.IsValid)
            {
                _employeeData.getSeachEmployees(obj.EmployeeName);
            }

        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]EemployeeDb obj)
        {
            if (ModelState.IsValid)
            {
                _employeeData.updateEmployee(obj);
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _employeeData.deleteEmployee(id);
            }
        }
    }
}
