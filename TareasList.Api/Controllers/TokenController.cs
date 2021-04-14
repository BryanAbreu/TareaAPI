using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;
using TareasList.Core.Interfaces;

namespace TareasList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILoginService _loginService;
        public TokenController(IConfiguration configuration, ILoginService loginService)
        {
            _configuration = configuration;
            _loginService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult> Authentication(UserLogin login)
        {
            var validation = await IsValidUser(login);
            //if user is valid
            if (validation.Item1)
            {
                var token = GenerateToken(validation.Item2);
                return Ok(new { token });
            }
            return NotFound();
        }
        private async Task<(bool, User)> IsValidUser(UserLogin login)
        {
            var user = await _loginService.GetLoginByCredentials(login);
            return (true, user);
        }
        private string GenerateToken(User user)
        {
            //Header
            var _SymmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]));

            var SigninCredentials = new SigningCredentials(_SymmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(SigninCredentials);

            //Claims
            var Claims = new[]
            {
            new Claim(ClaimTypes.Name, user.Name)
            };

            //payload
            var payload = new JwtPayload(
               _configuration["Authentication:Issuer"],
               _configuration["Authentication:Audience"],
              Claims,
               DateTime.Now,
               DateTime.UtcNow.AddMinutes(2)
           ) ;
            var token = new JwtSecurityToken(header, payload);
            return new JwtSecurityTokenHandler().WriteToken(token);
            
        }

    }
}
