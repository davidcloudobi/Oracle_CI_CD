using GitHubActionsDemo;
using GitHubActionsDemo.Controllers;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace GitHubActions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(1 == 1);

        }

        //[Fact]
        //public async Task CustomerIntegrationTest()
        //{
        //    var context = new CustomerContextFactory().CreateDbContext();

        //    await context.Database.EnsureDeletedAsync();
        //    await context.Database.EnsureCreatedAsync();

        //    var controller = new CustomersController(context);

        //    await controller.Add(new Customer { CustomerName = "CloudObi" });

        //    var result = (await controller.GetAll()).ToArray();

        //    Assert.Single(result);
        //    Assert.Equal("CloudObi", result[0].CustomerName);

        //}
    }
}
