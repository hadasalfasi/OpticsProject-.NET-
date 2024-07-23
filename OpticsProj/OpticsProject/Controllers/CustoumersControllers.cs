using DAL.Dtos;
using DAL.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace OpticsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustoumersControllers : ControllerBase
    {
        private readonly ICustomer _dbCustomer;
        public CustoumersControllers(ICustomer customer)
        {
            _dbCustomer = customer;
        }

        [HttpPost]
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<IActionResult> Post([FromBody]CustomerDto value)
        {
          bool create=  await _dbCustomer.CreateCustomer(value);
            if (create)
                return Ok();
            return BadRequest();

        }
        [HttpDelete("{id}")]
        [Authorize(Policy = "RequireAdminRole")]
        public async Task<IActionResult> Delete(long id)
        {
            bool delete=await _dbCustomer.DeleteCustomer(id);
            if (delete)
                return Ok();
            return BadRequest();
        }
        [HttpGet("{id}")]
        [Authorize(Policy = "AdminOrCustomer")]
        public async Task<Customer> Get(long id)
        {
            Customer c=await _dbCustomer.GetCustomer(id);
            return c;

        }
        [HttpPut("{id}")]
       [Authorize(Policy = "RequireAdminRole")]
        public async Task<IActionResult> Put(long id, [FromBody] CustomerDto c)
        {
            bool put=await _dbCustomer.UpdateCostumer(id, c);
            if(put)
                return Ok();
            return BadRequest();
        }
    }
}
