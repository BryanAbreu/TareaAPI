using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareasList.Core.DTOS;
using TareasList.Core.Entities;
using TareasList.Core.Interfaces;

namespace TareasList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IMapper _mapper;
        public UsersController(ILoginService loginService, IMapper mapper )
        {
            _loginService = loginService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody] UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            await _loginService.RegisterUser(user);
            userDTO = _mapper.Map<UserDTO>(user);
            return Created(string.Empty, new { userDTO });
        }
    }
}
