using DietaDiaria.Domain.Users.Entities;
using DietaDiaria.Domain.Users.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaDiaria.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IUserRepository UserRepository { get; }

        [HttpGet]
        public async Task<List<User>> Get()
        {
            var result = await _userRepository.ToListAsync();
            return result.ToList();
        }
    }
}