using JobarCharityInitProject.Infrastructure.Integrations.Data.Models;
using Repository_pattern_API.DTOs.AddressDto;
using Repository_pattern_API.Infrastructure.Integrations.Data.Models;

namespace Repository_pattern_API.Services.AdressService
{
    public interface IAddressService
    {
        Task<Address> GetAddressByIdAsync(int id);
        Task<AddressCreateDto> Insert(AddressCreateDto obj);
        Task Update(AddressUpdateDto obj);
        Task<bool> DeleteAsync(int id);
    }
}
