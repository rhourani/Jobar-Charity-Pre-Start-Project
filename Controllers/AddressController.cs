using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository_pattern_API.DTOs.AddressDto;
using Repository_pattern_API.Infrastructure.Integrations.Data.Models;
using Repository_pattern_API.Services.AdressService;

namespace Repository_pattern_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("{id}")]
        public async Task<Address> Get(int id)
        {
            return await _addressService.GetAddressByIdAsync(id);
        }

        [HttpPost]
        public async Task<AddressCreateDto> Post([FromBody] AddressCreateDto address)
        {
            return await _addressService.Insert(address);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] AddressUpdateDto address)
        {
            if (id != address.Id)
            {
                return BadRequest("ID mismatch");
            }
            await _addressService.Update(address);
            return Ok("address updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _addressService.DeleteAsync(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
