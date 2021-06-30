using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubActionsDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
            
    }

    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
