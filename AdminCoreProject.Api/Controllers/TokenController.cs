using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AdminCoreProject.Cookie;
using AdminCoreProject.Entities;
using AdminCoreProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AdminCoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TokenController : ControllerBase
    {
        private IConfiguration _configuration;
        private ICustomerService _customerService;

        public TokenController(ICustomerService customerService,
                               IConfiguration configuration)
        {
            _configuration = configuration;
            _customerService = customerService;
        }

        [HttpPost]
        [Route("login-control")]
        public Customer GetCustomer([FromBody] Customer customer)
        {
            var _customer = _customerService.GetCustomer(customer);
            if (_customer != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, customer.Name),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var Token = new JwtSecurityToken
                (
                    issuer: _configuration["Issuer"],
                    audience: _configuration["Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddDays(30),
                    notBefore: DateTime.UtcNow,
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SigningKey"])),
                            SecurityAlgorithms.HmacSha256)
                );

                _customer.Token = new JwtSecurityTokenHandler().WriteToken(Token);
            }

            return _customer;
        }
    }
}