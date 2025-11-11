using CrediSoft.Application.DTOs;
using CrediSoft.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrediSoft.WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clients = await _service.GetAllUsersAsync();
            return Ok(clients);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var client = await _service.GetUserByIdAsync(id);
            if (client == null)
                return NotFound();

            return Ok(client);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClientAsync(CreateClientDto dto)
        {
            //await _service.RegisterUserAsync(dto);

            return Ok(dto);
        }
    }
}
