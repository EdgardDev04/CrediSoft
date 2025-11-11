using CrediSoft.Application.DTOs;
using CrediSoft.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrediSoft.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly LoanService _service;

        public LoanController(LoanService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clients = await _service.GetAllLoansAsync();
            return Ok(clients);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var client = await _service.GetLoanByIdAsync(id);
            if (client == null)
                return NotFound();

            return Ok(client);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClientAsync(CreateLoanDto dto)
        {
            await _service.CreateLoanAsync(dto);

            return Ok(dto);
        }
    }
}
