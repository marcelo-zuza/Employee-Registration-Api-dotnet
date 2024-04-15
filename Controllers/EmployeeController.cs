using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiEmployees.Context;
using ApiEmployees.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController
    {
        private readonly RegistrationContext _registrationContext;
        public EmployeeController(RegistrationContext registrationContext)
        {
            _registrationContext = registrationContext;
        }

        [HttpGet("Obtain All")]
        public IEnumerable<Employee> Get()
        {
            return _registrationContext.Employees.ToList();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _registrationContext.Add(employee);
            _registrationContext.SaveChanges();

            return new OkObjectResult(employee);
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _registrationContext.Employees.FirstOrDefault(e => e.Id == id);
        }

        [HttpPut]
        public IActionResult Update(Employee employee)
        {
            _registrationContext.Update(employee);
            _registrationContext.SaveChanges();
            return new OkResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _registrationContext.Employees.FirstOrDefault(e => e.Id == id);
            _registrationContext.Remove(employee);
            _registrationContext.SaveChanges();
            return new OkResult();
        }

        
    }
}