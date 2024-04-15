using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiEmployees.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmployees.Context
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext(DbContextOptions<RegistrationContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        
    }
}