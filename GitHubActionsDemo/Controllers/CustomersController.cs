using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubActionsDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        private CustomerDbContext context { get; set; }

        public CustomersController(CustomerDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAll()
        => await context.Customers.ToListAsync();

        [HttpPost]
        public async Task<Customer> Add(Customer c)
        {
            await context.Customers.AddAsync(c);
            await context.SaveChangesAsync();
            return c;
        }
    }
}
