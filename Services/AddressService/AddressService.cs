using JobarCharityInitProject.Infrastructure.Integrations.Data.Models;
using JobarCharityInitProject.Infrastructure.Integrations.Data.Services.EfService;
using Repository_pattern_API.DTOs.AddressDto;
using Repository_pattern_API.Infrastructure.Integrations.Data.Models;
using Repository_pattern_API.Infrastructure.Integrations.Data.Services.EfService;

namespace Repository_pattern_API.Services.AdressService
{
    public class AddressService : IAddressService   
    {
        private readonly IRepository<Address> _addressRepository;

        public AddressService(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<Address> GetAddressByIdAsync(int id)
        {
            return await _addressRepository.GetByIdAsync(id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _addressRepository.GetByIdAsync(id);
            if (entity == null)
                return false;

            await _addressRepository.DeleteAsync(entity);
            return true;
        }

        public async Task<AddressCreateDto> Insert(AddressCreateDto obj)
        {
            var address = new Address 
            {
                City = obj.City,
                Country = obj.Country,
                HomeNum = obj.HomeNum,
                FullAddress = obj.FullAddress,
                StreetName = obj.StreetName,
            };
             await _addressRepository.AddAsync(address);
            return obj;
        }

        public async Task Update(AddressUpdateDto obj)
        {
            var address = new Address
            {
                Id=obj.Id,
                City = obj.City,
                Country = obj.Country,
                HomeNum = obj.HomeNum,
                FullAddress = obj.FullAddress,
                StreetName = obj.StreetName,
            };
            await _addressRepository.UpdateAsync(address);
        }
    }
}
