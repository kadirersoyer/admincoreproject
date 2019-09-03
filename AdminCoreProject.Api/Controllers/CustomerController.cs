using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminCoreProject.Entities;
using AdminCoreProject.Entities.DTOs;
using AdminCoreProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminCoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("get-customer-list")]
        public IActionResult GetCustomerList()
        {
            var data = _customerService.GetCustomers();
            if (data.Count > 0)
                return Ok(data);
            else
                return NotFound();
        }

        [HttpPost]
        [Route("customer-login-control")]
        public IActionResult LoginControl([FromBody] CustomerLoginDTO customerLogin)
        {
            //return
            var customer = _customerService.GetCustomer(new Customer()
            {
                guid = new Guid().ToString(), id = 0,
                Name = customerLogin.Name,
                password = customerLogin.password,
                Surname = customerLogin.Surname
            });

            return Ok(customer);
        }
    }
}