using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain;
using OrderManagement.Logic;

namespace OrderManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public IOrderManagementLogic Logic { get; set; }

        public CustomersController(IOrderManagementLogic orderManagementLogic)
        {
            this.Logic = orderManagementLogic;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await Logic.GetCustomers();
        }
    }
}
